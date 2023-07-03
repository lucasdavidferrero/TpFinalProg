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
        public static bool PropietarioAdmiteProyecto(int idPropietario) {

            //NO HABRIA QUE PONER BAJA TAMBIEN ACA?

            string q = "SELECT id_proyecto FROM Proyecto WHERE id_propietario_FK = @Id;";

            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();
            DataTable dt = new DataTable();

            cmd.Parameters.AddWithValue("@Id", idPropietario);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);

                if (dt.Rows.Count < 3) {
                    return true;
                }
            } catch (SqlException e) {
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
                    // Acceder a los valores de cada columna en la fila actual
                    int id = Convert.ToInt32(row["id_funcion_fk"]);

                    if (id == 1) {
                        return false;
                    }
                }
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
                return false;
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return true;
        }
    }
}
