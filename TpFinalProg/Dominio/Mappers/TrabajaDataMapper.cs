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
        public static Tuple<int, int, int> InsertNew(Trabaja trabaja)
        {
            string query = @"INSERT INTO Trabaja(legajo, id_proyecto, id_tarea, id_funcion_fk)
                OUTPUT inserted.legajo, inserted.id_proyecto, inserted.id_tarea
                VALUES (@nroLegajo, @idProyecto, @idTarea, @idFuncion)";


            Tuple<int, int, int> generatedId = null;
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
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int legajo = Convert.ToInt32(reader["legajo"]);
                        int idProyecto = Convert.ToInt32(reader["id_proyecto"]);
                        int idTarea = Convert.ToInt32(reader["id_tarea"]);
                        generatedId = Tuple.Create(legajo, idProyecto, idTarea);
                    }

                    return generatedId;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return generatedId;
        }

        public static List<Trabaja> GetAll()
        {
            List<Trabaja> trabajas = new List<Trabaja>();
            string query = "SELECT * FROM Trabaja";
            Conexion cx = new Conexion();
            DataTable dt = new DataTable();

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int nroLegajo = Convert.ToInt32(row["legajo"]);
                    int idProyecto = Convert.ToInt32(row["id_proyecto"]);
                    int idTarea = Convert.ToInt32(row["id_tarea"]);
                    int idFuncion = Convert.ToInt32(row["id_funcion_fk"]);

                    Trabaja trabaja = new Trabaja(nroLegajo, idProyecto, idTarea, idFuncion);
                    trabajas.Add(trabaja);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Listado Trabajas]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return trabajas;
        }

        public static Tuple<int, int, int> Update(Trabaja trabaja)
        {
            string query = "UPDATE Trabaja SET id_funcion_fk = @idFuncion WHERE legajo = @nroLegajo AND id_proyecto = @idProyecto AND id_tarea = @idTarea";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@idFuncion", SqlDbType.Int);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);

            cmd.Parameters["@idFuncion"].Value = trabaja.idFuncion;
            cmd.Parameters["@nroLegajo"].Value = trabaja.nroLegajo;
            cmd.Parameters["@idProyecto"].Value = trabaja.idProyecto;
            cmd.Parameters["@idTarea"].Value = trabaja.idTarea;

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return Tuple.Create(trabaja.nroLegajo, trabaja.idProyecto, trabaja.idTarea);
        }

        public static Trabaja FindById(int nroLegajo, int idProyecto, int idTarea)
        {
            Trabaja trabajaEncontrada = null;
            string query = "SELECT * FROM Trabaja WHERE legajo = @nroLegajo AND id_proyecto = @idProyecto AND id_tarea = @idTarea";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@nroLegajo", nroLegajo);
            cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
            cmd.Parameters.AddWithValue("@idTarea", idTarea);

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    int idFuncion = Convert.ToInt32(row["id_funcion_fk"]);

                    trabajaEncontrada = new Trabaja(nroLegajo, idProyecto, idTarea, idFuncion);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Trabaja]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return trabajaEncontrada;
        }
    }

}
