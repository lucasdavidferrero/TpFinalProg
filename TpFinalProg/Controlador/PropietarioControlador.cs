using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using Microsoft.Data.SqlClient;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class PropietarioControlador {

        public static void crear () {
            Propietario clsPropietario = new Propietario(0, "Ferreros S.A", 38981227, "3493435048", "luki@gmail.com", "Nicolás Ferrero");
            int idGenerado = clsPropietario.save();
            Console.WriteLine("Id generado: " + idGenerado);
        }

        public static void actualizar () { }

        public static void eliminar() { }

        public static DataTable listarTodo() {
            Propietario clsPropietario = new Propietario();
            DataTable propietarios = clsPropietario.getAll();
            return propietarios;

            DataTable dtListaAll = new DataTable("Lista todos");
            String sql = "Select * from Propietario where baja = 0";
            try {
                Conexion Cx = new Conexion();
                Cx.SetComandoSQL(sql);

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter sqlDat = new SqlDataAdapter(Cx.getComando());
                sqlDat.Fill(dtListaAll);//Llenamos el DataSet
            } catch (Exception) {
                dtListaAll = null;
            }
            return dtListaAll;
        }

    }
}
