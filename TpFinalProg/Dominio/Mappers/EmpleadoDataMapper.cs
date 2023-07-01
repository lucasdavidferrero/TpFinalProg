using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;



namespace TpFinalProg.Dominio.Mappers {
    internal class EmpleadoDataMapper {
        public static int IsertNew(Empleado empleado) {

            string queryString = "INSERT INTO Empleados (NroLegajo, FechaIngreso, Nombre, Apellido, Celular, Email) " +
                "VALUES (@NroLegajo, @FechaIngreso, @Nombre, @Apellido, @Celular, @Email)";
            int idGenerado = -1;

            try {
                Conexion cx = new Conexion();
                SqlCommand cmd = cx.getComando();

                cx.SetComandoSQL(queryString);



                cmd.Parameters.AddWithValue("@NroLegajo", empleado.nroLegajo);
                cmd.Parameters.AddWithValue("@FechaIngreso", empleado.fechaIngreso);
                cmd.Parameters.AddWithValue("@Nombre", empleado.nombre);
                cmd.Parameters.AddWithValue("@Apellido", empleado.apellido);
                cmd.Parameters.AddWithValue("@Celular", empleado.celular);
                cmd.Parameters.AddWithValue("@Email", empleado.email);

                cmd.ExecuteNonQuery();

                string obtenerIdQuery = "SELECT SCOPE_IDENTITY()";
                cx.SetComandoSQL(obtenerIdQuery);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());

                

            } catch (SqlException ex) {
                MessageBox.Show("Error al insertar el empleado: " + ex.ToString());

            }

            return idGenerado;

        }
    }
}
