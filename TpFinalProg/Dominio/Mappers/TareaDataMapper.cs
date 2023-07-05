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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.MonthCalendar;

namespace PruebaTpFinal.Dominio.Mappers
{
    internal class TareaDataMapper
    {
        public static Tuple<int, int> insertarNuevo(Tarea tarea)
        {
            string query = @"
        INSERT INTO Tarea (id_proyecto, nro_tarea, descripcion, horas_estimadas, horas_avance, costo_estimado, horas_reales, costo_real)
        OUTPUT INSERTED.id_proyecto, INSERTED.nro_tarea
        VALUES (@idProyecto, @idTarea, @descripcion, @horasEstimadas, @horasAvance, @costoEstimado, @horasReales, @costoReal)";

            Tuple<int, int>? generatedId = null;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@horasEstimadas", SqlDbType.Int);
            cmd.Parameters.Add("@horasAvance", SqlDbType.Int);
            cmd.Parameters.Add("@costoEstimado", SqlDbType.Decimal);
            cmd.Parameters.Add("@horasReales", SqlDbType.Int);
            cmd.Parameters.Add("@costoReal", SqlDbType.Decimal);

            cmd.Parameters["@idProyecto"].Value = tarea.idProyecto;
            cmd.Parameters["@idTarea"].Value = tarea.idTarea;
            cmd.Parameters["@descripcion"].Value = tarea.descripcion;
            cmd.Parameters["@horasEstimadas"].Value = tarea.horasEstimadas;
            cmd.Parameters["@horasAvance"].Value = tarea.horasAvance;
            cmd.Parameters["@costoEstimado"].Value = tarea.costoEstimado;
            cmd.Parameters["@horasReales"].Value = tarea.horasReales;
            cmd.Parameters["@costoReal"].Value = tarea.costoReal;

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

        public static Tuple<int, int>? modificar(Tarea tarea)
        {
            string query = "UPDATE Tarea SET descripcion = @descripcion, horas_estimadas = @horasEstimadas, horas_avance = @horasAvance, " +
                           "costo_estimado = @costoEstimado, horas_reales = @horasReales, costo_real = @costoReal " +
                           "WHERE id_proyecto = @idProyecto AND nro_tarea = @idTarea AND baja = 0";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            cmd.Parameters.Add("@horasEstimadas", SqlDbType.Int);
            cmd.Parameters.Add("@horasAvance", SqlDbType.Int);
            cmd.Parameters.Add("@costoEstimado", SqlDbType.Decimal);
            cmd.Parameters.Add("@horasReales", SqlDbType.Int);
            cmd.Parameters.Add("@costoReal", SqlDbType.Decimal);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);

            cmd.Parameters["@descripcion"].Value = tarea.descripcion;
            cmd.Parameters["@horasEstimadas"].Value = tarea.horasEstimadas;
            cmd.Parameters["@horasAvance"].Value = tarea.horasAvance;
            cmd.Parameters["@costoEstimado"].Value = tarea.costoEstimado;
            cmd.Parameters["@horasReales"].Value = tarea.horasReales;
            cmd.Parameters["@costoReal"].Value = tarea.costoReal;
            cmd.Parameters["@idProyecto"].Value = tarea.idProyecto;
            cmd.Parameters["@idTarea"].Value = tarea.idTarea;

            Tuple<int, int>? idModificado = null;

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteReader();
                idModificado = Tuple.Create(tarea.idProyecto, tarea.idTarea);
                return idModificado;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Tarea]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idModificado;
        }

        public static Tarea encontrarPorId(int idProyecto, int idTarea)
        {
            Tarea? tareaEncontrada = null;
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
                    decimal costoEstimado = Convert.ToDecimal(row["costo_estimado"]);
                    int horasReales = Convert.ToInt32(row["horas_reales"]);
                    decimal costoReal = Convert.ToDecimal(row["costo_real"]);
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

        public static DataTable obtenerTareasActivasPorIdProyecto (int idProyecto) {
            string query = $"SELECT nro_tarea,descripcion FROM Tarea " +
                $"WHERE id_proyecto = {idProyecto} AND fecha_final IS NULL AND baja = 0;";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

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

        public static int eliminar(int idProyecto, int idTarea) {
            string query = @"UPDATE Tarea SET baja = 1 WHERE id_proyecto = @idProyecto AND nro_tarea = @idTarea AND baja = 0";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters["@idProyecto"].Value = idProyecto;
            cmd.Parameters.Add("@idTarea", SqlDbType.Int);
            cmd.Parameters["@idTarea"].Value = idTarea;

            int rowsAffected = 0;

            try {
                cx.SetComandoSQL(query);
                rowsAffected = cmd.ExecuteNonQuery();
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Eliminar Proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }

        public static DataSet cargarCombo() {
            DataSet dt = new DataSet();
            string sql = "Select 0 as id_proyecto, 'Seleccione...' as nombre " +
                "Union SELECT id_proyecto, nombre FROM Proyecto where baja= 0 order by id_proyecto";

            try {
                Conexion cx = new Conexion();
                SqlCommand cmd = cx.getComando();
                cx.SetComandoSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                cx.cerrarConexionLiberarRecursos();

            } catch (SqlException ex) {
                return null;
            }
            return dt;
        }


        public static DataTable? validarExistenciaTareasPorProyecto(int idProyecto) {
            string query = "SELECT id_proyecto, nro_tarea FROM Tarea WHERE id_proyecto = @idProyecto AND baja = 0";
            
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();
            DataTable dt = new DataTable();
            

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

            if (dt.Rows.Count == 0) {
                // No se encontraron tareas para el proyecto dado
                // Realiza la lógica adecuada aquí
                return null;
            } 
            // Se encontraron tareas para el proyecto dado
            // Puedes acceder a los datos en el DataTable y realizar la lógica adecuada aquí
            

            return dt;
        }

        public static DataTable? obtenerUltimoIdTarea(int idProyecto) {
            string query = "SELECT nro_tarea FROM Tarea WHERE id_proyecto = @idProyecto";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();
            DataTable dt = new DataTable();


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

            if (dt.Rows.Count == 0) {
                // No se encontraron tareas para el proyecto dado
                // Realiza la lógica adecuada aquí
                return null;
            }
            // Se encontraron tareas para el proyecto dado
            // Puedes acceder a los datos en el DataTable y realizar la lógica adecuada aquí


            return dt;
        }
    }

}
