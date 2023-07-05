using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;
using static System.Windows.Forms.MonthCalendar;

namespace PruebaTpFinal.Dominio.Mappers
{
    internal class TrabajaDataMapper
    {
        public static int insertarNuevo(Trabaja trabaja)
        {
            string query = @"INSERT INTO Trabaja(legajo, id_proyecto, id_tarea, id_funcion_fk) VALUES (@nroLegajo, @idProyecto, @idTarea, @idFuncion);SELECT SCOPE_IDENTITY();";


            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);
            cmd.Parameters.Add("@idFuncion", SqlDbType.Int);

            cmd.Parameters["@nroLegajo"].Value = trabaja.nroLegajo;
            cmd.Parameters["@idProyecto"].Value = trabaja.idProyecto;
            cmd.Parameters["@idTarea"].Value = trabaja.idTarea;
            cmd.Parameters["@idFuncion"].Value = trabaja.idFuncion;

            try
            {
                cx.SetComandoSQL(query);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idGenerado;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }

        public static DataTable obtenerTodos()
        {
            string query = "SELECT * FROM Trabaja WHERE baja = 0";
            Conexion cx = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Listado Trabajas]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dt;
        }

        public static int modificar(Trabaja trabaja)
        {
            string query = "UPDATE Trabaja SET id_funcion_fk = @idFuncion, legajo = @nroLegajo, id_proyecto = @idProyecto, id_tarea = @idTarea WHERE id_trabaja = @idTrabaja AND baja = 0";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            int idGenerado = -1;

            cmd.Parameters.Add("@idTrabaja", SqlDbType.Int);
            cmd.Parameters.Add("@idFuncion", SqlDbType.Int);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);

            cmd.Parameters["@idTrabaja"].Value = trabaja.idTrabaja;
            cmd.Parameters["@idFuncion"].Value = trabaja.idFuncion;
            cmd.Parameters["@nroLegajo"].Value = trabaja.nroLegajo;
            cmd.Parameters["@idProyecto"].Value = trabaja.idProyecto;
            cmd.Parameters["@idTarea"].Value = trabaja.idTarea;

            try
            {
                cx.SetComandoSQL(query);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idGenerado;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }

        public static DataTable? encontrarPorId(int idTrabaja)
        {
            
            string query = "SELECT * FROM Trabaja WHERE id_trabaja = @idTrabaja AND baja = 0";
            DataTable? dt = null;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@idTrabaja", idTrabaja);
            

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dt;
        }

        public static bool eliminar(Trabaja trabaja) {
            string query = "DELETE FROM Trabaja WHERE id_trabaja = @idTrabaja";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            
            cmd.Parameters.Add("@idTrabaja", SqlDbType.Int);
            cmd.Parameters["@idtrabaja"].Value = trabaja.idTrabaja;
            

            try {
                cx.SetComandoSQL(query);
                cmd.ExecuteScalar();
                return true;

            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Eliminar Trabaja]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return false;
        }

        public static DataTable buscarPorCaracteristicas(int legajo, int idProyecto, int nroTarea) {

            string query = $"SELECT * FROM Trabaja WHERE legajo = {legajo} AND id_proyecto = {idProyecto} AND id_tarea = {nroTarea} AND baja = 0";
            DataTable? dt = new();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            


            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Trabaja]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dt;
        }

    }

}
