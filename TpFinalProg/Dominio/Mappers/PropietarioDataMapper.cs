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
    internal class PropietarioDataMapper {

        public static int insertNew (Propietario p) {
            // Construcción del query parametrizado.
            string q = "INSERT INTO Propietario(razon_social,telefono,email,cuit,persona_contacto) VALUES(@razonSocial,@telefono,@email,@cuit,@personaContacto) OUTPUT INSERTED.Id;";
            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@razonSocial", SqlDbType.NVarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@cuit", SqlDbType.BigInt);
            cmd.Parameters.Add("@personaContacto", SqlDbType.NVarChar);

            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@razonSocial"].Value = p.razonSocial;
            cmd.Parameters["@telefono"].Value = p.telefono;
            cmd.Parameters["@email"].Value = p.email;
            cmd.Parameters["@cuit"].Value = p.cuit;
            cmd.Parameters["@personaContacto"].Value = p.personaContacto;

            // Ejecución del SQL
            try {
                cx.SetComandoSQL(q);
                idGenerado = (int)cmd.ExecuteScalar();
                return idGenerado;
            } catch(SqlException e) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }
        public static DataTable getAll() {
            DataTable dtListAll = new DataTable("ListarPropietarios");
            string q = "SELECT * FROM Propietario";
            Conexion cx = new Conexion();
            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);

            } catch (SqlException e) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Propietarios]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }
    }
}
