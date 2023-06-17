using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class PropietarioControlador {

        public static void crear () {

        }

        public static void actualizar () { }

        public static void eliminar() { }

        public static DataTable listarTodo() {
            Propietario clsPropietario = new Propietario();
            DataTable propietarios = clsPropietario.getAll();
            return propietarios;
        }

    }
}
