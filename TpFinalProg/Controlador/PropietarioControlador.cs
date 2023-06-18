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
        }

    }
}
