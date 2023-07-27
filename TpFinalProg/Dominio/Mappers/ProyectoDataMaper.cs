using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Utilidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PruebaTpFinal.Dominio.Mappers
{
    internal class ProyectoDataMapper
    {
        public static int insertarNuevo(Proyecto proyecto)
        {
            string query = @"INSERT INTO Proyecto(nombre, monto_estimado, tiempo_estimado, id_propietario_FK, legajo_FK)
                         VALUES (@nombre, @montoEstimado, @tiempoEstimado, @idPropietario, @nroLegajo);
                         SELECT SCOPE_IDENTITY();";

            int generatedId = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@montoEstimado", SqlDbType.Decimal);
            cmd.Parameters.Add("@tiempoEstimado", SqlDbType.Int);
            cmd.Parameters.Add("@idPropietario", SqlDbType.Int);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);

            cmd.Parameters["@nombre"].Value = proyecto.nombre;
            cmd.Parameters["@montoEstimado"].Value = proyecto.montoEstimado;
            cmd.Parameters["@tiempoEstimado"].Value = proyecto.tiempoEstimado;
            cmd.Parameters["@idPropietario"].Value = proyecto.idPropietario;
            cmd.Parameters["@nroLegajo"].Value = proyecto.nroLegajo;

            try
            {
                cx.SetComandoSQL(query);
                generatedId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return generatedId;
        }

       public static DataTable? obtenerTodos()
        {
            DataTable? dtListAll = new DataTable("ListarProyectos");
            string query = "SELECT * FROM Proyecto WHERE baja = 0";
            Conexion cx = new Conexion();

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);
            }
            catch (SqlException)
            {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Proyectos]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static DataTable? cargarCb() {
            DataTable? dtListAll = new DataTable("ListarProyectos");
            string query = "SELECT 0 AS id_proyecto, 'Seleccione...' AS nombre\r\nUNION\r\nSELECT id_proyecto, nombre FROM Proyecto WHERE baja = 0\r\n";
            Conexion cx = new Conexion();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);
            } catch (SqlException) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Proyectos]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static DataTable? obtenerTodosParametros() {
            DataTable? dtListAll = new DataTable("ListarProyectos");
            string query = "SELECT Proyecto.id_proyecto, Proyecto.nombre,Propietario.razon_social, Empleado.legajo, Empleado.nombre+ ' '+apellido, " +
                "Proyecto.monto_estimado, Proyecto.tiempo_estimado, Proyecto.baja FROM Proyecto INNER JOIN " +
                "Propietario ON Propietario.id_propietario = Proyecto.id_propietario_FK INNER JOIN " +
                "Empleado ON Empleado.legajo = Proyecto.legajo_FK where Proyecto.baja = 0";
            Conexion cx = new Conexion();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);
            } catch (SqlException) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Proyectos]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static DataTable? obtenerProyectosActivosConTareasDisponiblesParaAsignar () {
            DataTable? dtListAll = new DataTable("ListarProyectos");
            string query = "SELECT DISTINCT Proyecto.id_proyecto, Proyecto.nombre as proyecto_nombre " +
                "FROM Proyecto INNER JOIN Tarea ON Proyecto.id_proyecto = Tarea.id_proyecto " +
                "WHERE Proyecto.baja = 0 AND Proyecto.fecha_final IS NULL AND Tarea.baja = 0 AND Tarea.fecha_final IS NULL;";
            Conexion cx = new Conexion();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);
            } catch (SqlException) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Proyectos]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }
        
        public static int modificar(Proyecto proyecto)
        {
            string query = @"UPDATE Proyecto
                         SET nombre = @nombre,
                             monto_estimado = @montoEstimado,
                             tiempo_estimado = @tiempoEstimado,
                             id_propietario_FK = @idPropietario,
                             legajo_FK = @nroLegajo
                         WHERE id_proyecto = @idProyecto AND baja = 0";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@montoEstimado", SqlDbType.Decimal);
            cmd.Parameters.Add("@tiempoEstimado", SqlDbType.Int);
            cmd.Parameters.Add("@idPropietario", SqlDbType.Int);
            cmd.Parameters.Add("@nroLegajo", SqlDbType.Int);
            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);

            cmd.Parameters["@nombre"].Value = proyecto.nombre;
            cmd.Parameters["@montoEstimado"].Value = proyecto.montoEstimado;
            cmd.Parameters["@tiempoEstimado"].Value = proyecto.tiempoEstimado;
            cmd.Parameters["@idPropietario"].Value = proyecto.idPropietario;
            cmd.Parameters["@nroLegajo"].Value = proyecto.nroLegajo;
            cmd.Parameters["@idProyecto"].Value = proyecto.idProyecto;

            int rowsAffected = 0;

            try
            {
                cx.SetComandoSQL(query);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }


        public static Proyecto? encontrarPorId(int id)
        {
            Proyecto? proyectoEncontrado = null;
            string query = "SELECT * FROM Proyecto WHERE id_proyecto = @Id AND baja = 0";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlData = new SqlDataAdapter(cx.getComando());
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    int pId = Convert.ToInt32(row["id_proyecto"]);
                    string? pNombre = row["nombre"].ToString();
                    Decimal pMontoEstimado = Convert.ToDecimal(row["monto_estimado"]);
                    int pTiempoEstimado = Convert.ToInt32(row["tiempo_estimado"]);
                    int pIdPropietario = Convert.ToInt32(row["id_propietario_FK"]);
                    int pNroLegajo = Convert.ToInt32(row["legajo_FK"]);

                    proyectoEncontrado = new Proyecto(pId, pNombre, pMontoEstimado, pTiempoEstimado, pIdPropietario, pNroLegajo);
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por ID de Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return proyectoEncontrado;
        }


        public static int eliminar(int idProyecto)
        {
            string query = @"UPDATE Proyecto SET baja = 1 WHERE id_proyecto = @idProyecto AND baja = 0";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@idProyecto", SqlDbType.Int);
            cmd.Parameters["@idProyecto"].Value = idProyecto;

            int rowsAffected = 0;

            try
            {
                cx.SetComandoSQL(query);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error en la base de datos. [Eliminar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }

        public static void finalizarProyectoPorId (int idProyecto) {
            string query = @"UPDATE Proyecto SET fecha_final = @fechaFinal WHERE id_proyecto = @idProyecto";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@fechaFinal", SqlDbType.Date);
            cmd.Parameters["@fechaFinal"].Value = DateTime.Now.Date;
            cmd.Parameters.AddWithValue("@idProyecto", idProyecto);

            try {
                cx.SetComandoSQL(query);
                cmd.ExecuteNonQuery();
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Finalizar Proyecto por Id]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
        }

        public static DataTable? BuscarProyectos(string nombreBusqueda) {
            string query = @"SELECT
    P.nombre AS 'Nombre del Proyecto',
    Prop.razon_social AS 'Empresa',
    P.monto_estimado AS 'Costo Estimado',
    SUM(T.costo_real) AS 'Costo Real Total',
    ROUND((SUM(T.costo_real) - P.monto_estimado) / P.monto_estimado * 100, 2) AS 'Porcentaje de Desvío',
    SUM(CASE WHEN T.fecha_final IS NOT NULL THEN 1 ELSE 0 END) * 100 / COUNT(*) AS 'Porcentaje de Tareas Terminadas'
FROM
    Proyecto P
    INNER JOIN Propietario Prop ON P.id_propietario_FK = Prop.id_propietario
    LEFT JOIN Tarea T ON P.id_proyecto = T.id_proyecto
    LEFT JOIN Trabaja TR ON T.id_proyecto = TR.id_proyecto AND T.nro_tarea = TR.id_tarea 
WHERE
    P.baja = 0
    AND P.nombre LIKE '%' + @nombreBusqueda + '%'
    AND T.baja = 0
GROUP BY
    P.id_proyecto,
    P.nombre,
    Prop.razon_social,
    P.monto_estimado;";

            DataTable dtProyectos = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@nombreBusqueda", nombreBusqueda);

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtProyectos);
                return dtProyectos;
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Buscar Proyectos]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return null;
        }

        public static DataTable? obtenerProyectosConEmpresa (bool esTerminado = false) {
            string query = $"SELECT P.id_proyecto, P.nombre as 'nombre_proyecto', P.monto_estimado, Prop.razon_social as 'nombre_empresa' " +
                $"FROM Proyecto P INNER JOIN Propietario Prop ON P.id_propietario_FK = Prop.id_propietario WHERE P.baja = 0 AND P.fecha_final {(esTerminado ? "IS NOT" : "IS")} NULL;";
            DataTable dtProyectos = new DataTable("ListadoProyectos");
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtProyectos);
                return dtProyectos;
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [obtenerProyectosSinFinalizarConEmpresa]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return null;
        }


    }

}
