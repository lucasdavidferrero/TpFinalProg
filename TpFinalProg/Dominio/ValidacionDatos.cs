using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;

namespace TpFinalProg.Dominio {
    internal class ValidacionDatos {

        public static int responsableCantidadProyectosActivos (int legajo) {
            
            string q = $"SELECT COUNT(id_proyecto) as numProyectos FROM Proyecto WHERE legajo_FK = {legajo} AND fecha_final IS NULL AND baja = 0;";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            try {
                cx.SetComandoSQL(q);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                if (dt.Rows.Count > 0) {
                    int numProyectos = Convert.ToInt16(dt.Rows[0][0]);
                    return numProyectos;
                }
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Validación Responsable Cant. Proyectos Activos]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return 0;
        }
        
        public static bool PropietarioAdmiteProyecto(int idPropietario) {

            // Las Reglas de negocio (validaciones de datos) van en las entidades.
            //NO HABRIA QUE PONER BAJA TAMBIEN ACA. 

            string q = "SELECT id_proyecto FROM Proyecto WHERE id_propietario_FK = @Id;";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();
            DataTable dt = new DataTable();

            cmd.Parameters.AddWithValue("@Id", idPropietario);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                if (dt.Rows.Count <= 3) {
                    return true;
                }
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return false;
        }


        public static bool TareaAdmiteLider(int idProyecto, int idTarea) {

            string q = "SELECT id_funcion_fk FROM Trabaja WHERE id_proyecto = @IdProyecto AND id_tarea = @IdTarea;";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();


            DataTable dtListAll = new DataTable("ListarFuncionesExistentes");

            cmd.Parameters.AddWithValue("@IdProyecto", idProyecto);
            cmd.Parameters.AddWithValue("@IdTarea", idTarea);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);

                foreach (DataRow row in dtListAll.Rows) {
                    // Acceder a los valores de cada columna en la fila actual.
                    // TODO: Usar descripcion=="Lider"
                    int id = Convert.ToInt32(row["id_funcion_fk"]);

                    if (id == 1) {
                        return false;
                    }
                }
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
                return false;
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return true;
        }
    }
}
