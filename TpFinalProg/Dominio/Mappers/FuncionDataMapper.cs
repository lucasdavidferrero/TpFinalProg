﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;

namespace PruebaTpFinal.Dominio.Mappers
{
    internal class FuncionDataMapper
    {
        public static int InsertNew(Funcion f)
        {
            string query = "INSERT INTO Funcion(descripcion) VALUES (@descripcion); SELECT SCOPE_IDENTITY();";

            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters["@descripcion"].Value = f.descripcion;

            try
            {
                cx.SetComandoSQL(query);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idGenerado;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Funcion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }

        public static DataTable GetAll()
        {
            DataTable dtListAll = new DataTable("ListarFunciones");
            string query = "SELECT * FROM Funcion WHERE baja = 0";
            Conexion cx = new Conexion();
            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);
            }
            catch (SqlException e)
            {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Funciones]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static int Update(Funcion f)
        {
            string query = "UPDATE Funcion SET descripcion = @descripcion WHERE id_funcion = @Id";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters["@descripcion"].Value = f.descripcion;

            cmd.Parameters.AddWithValue("@Id", f.idFuncion);

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Funcion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return f.idFuncion;
        }

        public static Funcion FindById(int id)
        {
            Funcion funcionEncontrada = null;
            string query = "SELECT * FROM Funcion WHERE id_funcion = @Id AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    int fId = Convert.ToInt32(row["id_funcion"]);
                    string fDescripcion = row["descripcion"].ToString();
                    funcionEncontrada = new Funcion(fId, fDescripcion);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Funcion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return funcionEncontrada;
        }

        public static bool Delete(int id)
        {
            string query = "UPDATE Funcion SET baja = 1 WHERE id_funcion = @Id";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Funcion eliminada correctamente");
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Eliminar Funcion]");
                return false;
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
        }
    }

    



}