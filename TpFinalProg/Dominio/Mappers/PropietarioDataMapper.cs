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
                Console.WriteLine("Error en la base de datos. [listado propietarios]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }
    }
}
