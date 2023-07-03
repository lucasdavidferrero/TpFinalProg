using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;

namespace PruebaTpFinal.Dominio.Mappers
{
    internal class TareaDataMapper
    {
        public static Tuple<int, int> insertarNuevo(Tarea tarea)
        {
            string query = @"
        INSERT INTO Tarea (id_proyecto, nro_tarea, descripcion, horas_estimadas, horas_avance, costo_estimado, horas_reales, costo_real, fecha_final)
        OUTPUT INSERTED.id_proyecto, INSERTED.nro_tarea
        VALUES (@idProyecto, @idTarea, @descripcion, @horasEstimadas, @horasAvance, @costoEstimado, @horasReales, @costoReal, @fechaFinal)";

            Tuple<int, int> generatedId = null;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@horasEstimadas", SqlDbType.Int);
            cmd.Parameters.Add("@horasAvance", SqlDbType.Int);
            cmd.Parameters.Add("@costoEstimado", SqlDbType.Float);
            cmd.Parameters.Add("@horasReales", SqlDbType.Int);
            cmd.Parameters.Add("@costoReal", SqlDbType.Float);
            cmd.Parameters.Add("@fechaFinal", SqlDbType.Date);

            cmd.Parameters["@idProyecto"].Value = tarea.idProyecto;
            cmd.Parameters["@idTarea"].Value = tarea.idTarea;
            cmd.Parameters["@descripcion"].Value = tarea.descripcion;
            cmd.Parameters["@horasEstimadas"].Value = tarea.horasEstimadas;
            cmd.Parameters["@horasAvance"].Value = tarea.horasAvance;
            cmd.Parameters["@costoEstimado"].Value = tarea.costoEstimado;
            cmd.Parameters["@horasReales"].Value = tarea.horasReales;
            cmd.Parameters["@costoReal"].Value = tarea.costoReal;
            cmd.Parameters["@fechaFinal"].Value = tarea.fechaFinal;

            try
            {
                cx.SetComandoSQL(query);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int idProyecto = Convert.ToInt32(reader["id_proyecto"]);
                        int idTarea = Convert.ToInt32(reader["nro_tarea"]);
                        generatedId = Tuple.Create(idProyecto, idTarea);
                    }

                    return generatedId;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Tarea]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return generatedId;
        }

        public static DataTable obtenerTodos()
        {
            List<Tarea> tareas = new List<Tarea>();
            string query = "SELECT * FROM Tarea WHERE baja = 0";
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
                Console.WriteLine("Error en la base de datos. [Listado Tareas]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dt;
        }

        public static Tuple<int, int> modificar(Tarea tarea)
        {
            string query = "UPDATE Tarea SET descripcion = @descripcion, horas_estimadas = @horasEstimadas, horas_avance = @horasAvance, " +
                           "costo_estimado = @costoEstimado, horas_reales = @horasReales, costo_real = @costoReal, fecha_final = @fechaFinal " +
                           "WHERE id_proyecto = @idProyecto AND nro_tarea = @idTarea AND baja = 0";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@horasEstimadas", SqlDbType.Int);
            cmd.Parameters.Add("@horasAvance", SqlDbType.Int);
            cmd.Parameters.Add("@costoEstimado", SqlDbType.Float);
            cmd.Parameters.Add("@horasReales", SqlDbType.Int);
            cmd.Parameters.Add("@costoReal", SqlDbType.Float);
            cmd.Parameters.Add("@fechaFinal", SqlDbType.Date);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);

            cmd.Parameters["@descripcion"].Value = tarea.descripcion;
            cmd.Parameters["@horasEstimadas"].Value = tarea.horasEstimadas;
            cmd.Parameters["@horasAvance"].Value = tarea.horasAvance;
            cmd.Parameters["@costoEstimado"].Value = tarea.costoEstimado;
            cmd.Parameters["@horasReales"].Value = tarea.horasReales;
            cmd.Parameters["@costoReal"].Value = tarea.costoReal;
            cmd.Parameters["@fechaFinal"].Value = tarea.fechaFinal;
            cmd.Parameters["@idProyecto"].Value = tarea.idProyecto;
            cmd.Parameters["@idTarea"].Value = tarea.idTarea;

            Tuple<int, int> idEncontado = null;

            try
            {
                cx.SetComandoSQL(query);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int idProyecto = Convert.ToInt32(reader["id_proyecto"]);
                        int idTarea = Convert.ToInt32(reader["nro_tarea"]);
                        idEncontado = Tuple.Create(idProyecto, idTarea);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Tarea]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idEncontado;
        }

        public static Tarea encontrarPorId(int idProyecto, int idTarea)
        {
            Tarea tareaEncontrada = null;
            string query = "SELECT * FROM Tarea WHERE id_proyecto = @idProyecto AND nro_tarea = @idTarea AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

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
                    string descripcion = row["descripcion"].ToString();
                    int horasEstimadas = Convert.ToInt32(row["horas_estimadas"]);
                    int horasAvance = Convert.ToInt32(row["horas_avance"]);
                    float costoEstimado = Convert.ToSingle(row["costo_estimado"]);
                    int horasReales = Convert.ToInt32(row["horas_reales"]);
                    float costoReal = Convert.ToSingle(row["costo_real"]);
                    DateTime fechaFinal = (DateTime)row["fecha_final"];

                    tareaEncontrada = new Tarea(idProyecto, idTarea, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal, fechaFinal);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Tarea]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return tareaEncontrada;
        }

        public static DataTable encontrarPorIdProyecto(int idProyecto) {
            string query = "SELECT * FROM Tarea WHERE id_proyecto = @idProyecto AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            List<Tarea> tareas = new();

            cmd.Parameters.AddWithValue("@idProyecto", idProyecto);

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Tarea]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dt;
        }
    }

}
