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

        public static int crear (string razon_social, Int64 cuit, string telefono,
            string email, string persona_contacto) {
            Propietario clsPropietario = new Propietario(0, razon_social, cuit, telefono, email, persona_contacto);
            int idGenerado = clsPropietario.save();
            return idGenerado;
        }

        public static void actualizar (int id_propietario, string razon_social, Int64 cuit, string telefono,
            string email, string persona_contacto) {
            Propietario p = new Propietario(id_propietario, razon_social, cuit, telefono, email, persona_contacto);
            p.save();
        }

        public static void eliminar() { }

        public static DataTable listarTodo() {
            Propietario clsPropietario = new Propietario();
            DataTable propietarios = clsPropietario.getAll();
            return propietarios;
        }

    }
}
