using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TpFinalProg.Dominio.Mappers {
    internal class EmpleadoDataMapper {

        public static int insertarNuevo(Empleado em) {
            // Construcción del query parametrizado.
            string q = "INSERT INTO Empleado(fecha_ingreso,nombre,apellido,celular,email) VALUES(@fechaIngreso,@nombre,@apellido,@celular,@email); SELECT SCOPE_IDENTITY();";
            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date);
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
            cmd.Parameters.Add("@celular", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);

            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@fechaIngreso"].Value = em.fechaIngreso;
            cmd.Parameters["@nombre"].Value = em.nombre;
            cmd.Parameters["@apellido"].Value = em.apellido;
            cmd.Parameters["@celular"].Value = em.celular;
            cmd.Parameters["@email"].Value = em.email;

            // Ejecución del SQL
            try {
                cx.SetComandoSQL(q);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idGenerado;
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Insertar Empleado]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }
        public static DataTable obtenerTodos() {
            DataTable dtListAll = new DataTable("ListarEmpleado");
            string q = "SELECT * FROM Empleado WHERE baja=0";
            Conexion cx = new Conexion();
            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);

            } catch (SqlException e) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Empleado]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }
        public static int modificar(Empleado em) {
            // Construcción del query parametrizado.
            string q = "UPDATE Empleado SET fecha_ingreso = @fecha_ingreso , nombre = @nombre, apellido = @apellido, celular = @celular, email = @email WHERE legajo = @Id AND baja = 0";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
            cmd.Parameters.Add("@celular", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);


            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@fecha_ingreso"].Value = em.fechaIngreso;
            cmd.Parameters["@nombre"].Value = em.nombre;
            cmd.Parameters["@apellido"].Value = em.apellido;
            cmd.Parameters["@celular"].Value = em.celular;
            cmd.Parameters["@email"].Value = em.email;

            cmd.Parameters.AddWithValue("@Id", em.legajo);

            // Ejecución del SQL
            try {
                cx.SetComandoSQL(q);
                cmd.ExecuteScalar();
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Insertar Empleado]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return em.legajo;
        }

        public static Empleado encontrarPorId(int id) {
            Empleado empEncontrado = null;
            string q = "SELECT * FROM Empleado WHERE legajo = @Id AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                if (dt.Rows.Count != 0) {
                    DataRow row = dt.Rows[0];
                    int eId = Convert.ToInt32(row["legajo"]);
                    DateTime eFechaIngreso = (DateTime)row["fecha_ingreso"];
                    string eNombre = row["nombre"].ToString()!;
                    string eApellido = row["apellido"].ToString()!;
                    string eCelular = row["celular"].ToString()!;
                    string eEmail = row["email"].ToString()!;
                    
                    empEncontrado = new Empleado(eId, eFechaIngreso, eNombre, eApellido, eCelular, eEmail);
                }
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Obtener por Legajo]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return empEncontrado;
        }

        public static void eliminar(int id) {
            string q = "UPDATE Empleado SET baja = @baja WHERE legajo = @Id AND baja = 0";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@baja", SqlDbType.Bit);
            cmd.Parameters["@baja"].Value = 1;

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                cmd.ExecuteScalar();
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Obtener por Legajo]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
        }

        //DE ACA
        public static DataSet cargarCombo() {
            DataSet dt = new DataSet();
            string sql = "  Select 0 as legajo, 'Seleccione...' as descripcion " +
                "Union SELECT legajo, nombre +' '+ apellido FROM Empleado WHERE baja=0 order by legajo";

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

        public static Empleado encontrarPorIdNombre(int id) {
            Empleado empEncontrado = null;
            string q = "  SELECT nombre +' '+ apellido  FROM Empleado WHERE legajo = @Id";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                cmd.ExecuteScalar();
            } catch (SqlException e) {
                Console.WriteLine("Error en la base de datos. [Obtener por Empleado Legajo]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return empEncontrado;
        }

    }
}
