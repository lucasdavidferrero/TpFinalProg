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
            cmd.Parameters.Add("@montoEstimado", SqlDbType.Float);
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
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Insertar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return generatedId;
        }

        public static DataTable obtenerTodos()
        {
            DataTable dtListAll = new DataTable("ListarProyectos");
            string query = "SELECT * FROM Proyecto WHERE baja = 0";
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
                Console.WriteLine("Error en la base de datos. [Listado Proyectos]");
            }
            finally
            {
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
            cmd.Parameters.Add("@montoEstimado", SqlDbType.Float);
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
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Actualizar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }


        public static Proyecto encontrarPorId(int id)
        {
            Proyecto proyectoEncontrado = null;
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
                    string pNombre = row["nombre"].ToString();
                    float pMontoEstimado = Convert.ToSingle(row["monto_estimado"]);
                    int pTiempoEstimado = Convert.ToInt32(row["tiempo_estimado"]);
                    int pIdPropietario = Convert.ToInt32(row["id_propietario_FK"]);
                    int pNroLegajo = Convert.ToInt32(row["legajo_FK"]);

                    proyectoEncontrado = new Proyecto(pId, pNombre, pMontoEstimado, pTiempoEstimado, pIdPropietario, pNroLegajo);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Obtener por ID de Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return proyectoEncontrado;
        }


        public static int Delete(int idProyecto)
        {
            string query = @"UPDATE Proyecto SET baja = 1 WHERE id_proyecto = @idProyecto";

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
            catch (SqlException e)
            {
                Console.WriteLine("Error en la base de datos. [Eliminar Proyecto]");
            }
            finally
            {
                cx.cerrarConexionLiberarRecursos();
            }

            return rowsAffected;
        }
    }

}
