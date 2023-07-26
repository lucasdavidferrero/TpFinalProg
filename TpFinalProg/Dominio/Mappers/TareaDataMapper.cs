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
        public static Tuple<int, int>? insertarNuevo(Tarea tarea)
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
            catch (SqlException)
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
            catch (SqlException)
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
                           "costo_estimado = @costoEstimado, horas_reales = @horasReales, costo_real = @costoReal";

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

            if (tarea.costoReal > 0 && tarea.horasReales > 0) {
                query += ", fecha_final = @fechaFinal";
                cmd.Parameters.Add("@fechaFinal", SqlDbType.Date);
                cmd.Parameters["@fechaFinal"].Value = DateTime.Now.Date;
            }

            query += " WHERE id_proyecto = @idProyecto AND nro_tarea = @idTarea AND baja = 0";

            Tuple<int, int>? idModificado = null;

            try
            {
                cx.SetComandoSQL(query);
                cmd.ExecuteReader();
                idModificado = Tuple.Create(tarea.idProyecto, tarea.idTarea);

                int cantTareasSinTerminar = obtenerCantidadTareasSinFinalizarPorIdProyecto(tarea.idProyecto);
                if (cantTareasSinTerminar == 0) {
                    ProyectoDataMapper.finalizarProyectoPorId(tarea.idProyecto); // todas las tareas fueron finalizadas. Se termina el proyecto.
                }
                return idModificado;
            }
            catch (SqlException)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Tarea]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }
            return idModificado;
        }

        public static Tarea? encontrarPorId(int idProyecto, int idTarea)
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
                    string? descripcion = row["descripcion"].ToString();
                    int horasEstimadas = Convert.ToInt32(row["horas_estimadas"]);
                    int horasAvance = Convert.ToInt32(row["horas_avance"]);
                    decimal costoEstimado = Convert.ToDecimal(row["costo_estimado"]);
                    int horasReales = Convert.ToInt32(row["horas_reales"]);
                    decimal costoReal = Convert.ToDecimal(row["costo_real"]);
                    DateTime fechaFinal = (DateTime)row["fecha_final"];

                    tareaEncontrada = new Tarea(idProyecto, idTarea, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal, fechaFinal);
                }
            }
            catch (SqlException)
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


            cmd.Parameters.AddWithValue("@idProyecto", idProyecto);

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                
            } catch (SqlException) {
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
            } catch (SqlException) {
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
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Eliminar Proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }

        public static DataSet? cargarCombo() {
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

            } catch (SqlException) {
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
                

            } catch (SqlException) {
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


            } catch (SqlException) {
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

        private static int obtenerCantidadTareasSinFinalizarPorIdProyecto (int idProyecto) {
            string query = $"SELECT COUNT(*) FROM Tarea WHERE id_proyecto = {idProyecto} AND baja = 0 AND fecha_final IS NULL;";
            int cantidadSinFinalizar = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();
            try {
                cx.SetComandoSQL(query);
                cantidadSinFinalizar = (int)cmd.ExecuteScalar();
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Cantidad Tareas sin finalizar por proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return cantidadSinFinalizar;
        }

        public static DataTable? obtenerTareasEnCursoPorIdProyeto (int idProyecto) {
            string query = $"SELECT nro_tarea, descripcion, horas_estimadas, costo_estimado, horas_avance FROM Tarea WHERE id_proyecto = {idProyecto} AND fecha_final is NULL AND baja = 0";
            DataTable dtTareas = new DataTable("ListadoTareas");
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtTareas);
                return dtTareas;
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Listar Tareas en curso por Proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return null;
        }

        public static DataTable? obtenerTareasFinalizadasPorIdProyeto(int idProyecto) {
            string query = $"SELECT nro_tarea, descripcion, horas_estimadas, costo_estimado, horas_avance, horas_reales, costo_real, CAST(100 - (costo_estimado / costo_real * 100)  AS DECIMAL(18, 2)) AS 'desvio',fecha_final " +
                $"FROM Tarea WHERE id_proyecto = {idProyecto} AND fecha_final is NOT NULL AND baja = 0";
            DataTable dtTareas = new DataTable("ListadoTareas");
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtTareas);
                return dtTareas;
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Listar Tareas Completadas en curso por Proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return null;
        }


        public static DataTable? BuscadorTareasPorProyecto(int idProyecto, string descripcionBusqueda) {
            string query = @"SELECT
    P.nombre AS 'nombre_proyecto',
    CONVERT(nvarchar(max), T.descripcion) AS 'descripcion',
    IIF((T.horas_reales >= T.horas_estimadas) OR (T.fecha_final IS NOT NULL), 'Cerrada', 'En Curso') AS 'estado',
	T.costo_estimado,
	T.costo_real,
	CAST(100 - (T.costo_estimado / T.costo_real * 100)  AS DECIMAL(18, 2)) AS 'desvio',
    CONCAT(Empleado.nombre, ' ', Empleado.apellido) AS 'empleado'
FROM
    Proyecto P
    INNER JOIN Propietario Prop ON P.id_propietario_FK = Prop.id_propietario
    LEFT JOIN Tarea T ON P.id_proyecto = T.id_proyecto
    LEFT JOIN Trabaja TR ON T.id_proyecto = TR.id_proyecto AND T.nro_tarea = TR.id_tarea
    LEFT JOIN Empleado ON TR.legajo = Empleado.legajo
WHERE
    P.baja = 0
	AND P.id_proyecto = @idProyecto
    AND T.descripcion LIKE '%' + @descripcionBusqueda + '%'
    AND T.baja = 0
    AND TR.id_tarea = T.nro_tarea
GROUP BY
    P.id_proyecto,
    P.nombre,
    CONVERT(nvarchar(max), T.descripcion),
    T.horas_reales,
    T.horas_estimadas,
	T.costo_estimado,
	T.costo_real,
    T.fecha_final,
    Empleado.nombre,
    Empleado.apellido;";

            DataTable dtTareas = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
            cmd.Parameters.AddWithValue("@descripcionBusqueda", descripcionBusqueda);

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtTareas);
                return dtTareas;
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Listar Tareas por Proyecto]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return null;
        }


        

    }

}
