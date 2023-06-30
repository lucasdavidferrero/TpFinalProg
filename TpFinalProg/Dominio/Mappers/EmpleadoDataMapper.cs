using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Dominio.Mappers {
    internal class EmpleadoDataMapper {

        public static int InsertarNuevo(Empleado p) {
            // Construcción del query parametrizado.
            string q = "INSERT INTO Empleado(fecha_ingreso,nombre,apellido,celular,email) VALUES(@fechaIngreso,@nombre,@apellido,@celular,@email); SELECT SCOPE_IDENTITY();";
            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@fechaIngreso", SqlDbType.NVarChar);
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
            cmd.Parameters.Add("@celular", SqlDbType.BigInt);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);

            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@fechaIngreso"].Value = p.fechaIngreso;
            cmd.Parameters["@nombre"].Value = p.nombre;
            cmd.Parameters["@apellido"].Value = p.apellido;
            cmd.Parameters["@celular"].Value = p.celular;
            cmd.Parameters["@email"].Value = p.email;

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
        public static DataTable ObtenerTodo() {
            DataTable dtListAll = new DataTable("ListarEmpleado");
            string q = "SELECT * FROM Empleado";
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
}
}
