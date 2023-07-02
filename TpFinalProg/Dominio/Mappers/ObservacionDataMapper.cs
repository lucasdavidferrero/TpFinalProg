using Microsoft.Data.SqlClient;
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
    public class ObservacionDataMapper
    {
        public static int InsertNew(Observacion observacion)
        {
            string query = "INSERT INTO Observacion(fecha, observacion, legajo_FK) VALUES (@fecha, @observacion, @nroLegajo);SELECT SCOPE_IDENTITY();";
            int generatedId = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            //cmd.Parameters.Add("@idObservacion", SqlDbType.Int);
            cmd.Parameters.Add("@fecha", SqlDbType.Date);
            cmd.Parameters.Add("@observacion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);

            //cmd.Parameters["@idObservacion"].Value = observacion.idObservacion;
            cmd.Parameters["@fecha"].Value = observacion.fecha;
            cmd.Parameters["@observacion"].Value = observacion.observacion;
            cmd.Parameters["@nroLegajo"].Value = observacion.nroLegajo;

            try
            {
                cx.SetComandoSQL(query);
                generatedId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Observacion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return generatedId;
        }

        public static DataTable GetAll()
        {
            DataTable dtListAll = new DataTable("ListarObservaciones");
            string query = "SELECT * FROM Observacion WHERE baja = 0";
            Conexion cx = new Conexion();

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlData = new SqlDataAdapter(cx.getComando());
                sqlData.Fill(dtListAll);
            }
            catch (SqlException e)
            {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Observaciones]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static int Update(Observacion observacion)
        {
            string query = "UPDATE Observacion SET fecha = @fecha, observacion = @observacion, legajo_FK = @nroLegajo WHERE id_observacion = @idObservacion";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@fecha", SqlDbType.Date);
            cmd.Parameters.Add("@observacion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);
            cmd.Parameters.Add("@idObservacion", SqlDbType.Int);

            cmd.Parameters["@fecha"].Value = observacion.fecha;
            cmd.Parameters["@observacion"].Value = observacion.observacion;
            cmd.Parameters["@nroLegajo"].Value = observacion.nroLegajo;
            cmd.Parameters["@idObservacion"].Value = observacion.idObservacion;

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Observacion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return observacion.idObservacion;
        }

        public static Observacion FindByID(int id)
        {
            Observacion observacionEncontrada = null;
            string query = "SELECT * FROM Observacion WHERE id_observacion = @idObservacion AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@idObservacion", id);

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlData = new SqlDataAdapter(cx.getComando());
                sqlData.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    int pIdObservacion = Convert.ToInt32(row["id_observacion"]);
                    DateTime pFecha = Convert.ToDateTime(row["fecha"]);
                    string pObservacion = row["observacion"].ToString();
                    int pNroLegajo = Convert.ToInt32(row["legajo_FK"]);

                    observacionEncontrada = new Observacion(pIdObservacion, pFecha, pObservacion, pNroLegajo);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por ID de Observacion]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return observacionEncontrada;
        }

        public static bool Delete(int id)
        {
            string query = "UPDATE Observacion SET baja = 1 WHERE id_observacion = @idObservacion";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@idObservacion", id);

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Eliminar Observacion]");
                return false;
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
        }
    }

}
