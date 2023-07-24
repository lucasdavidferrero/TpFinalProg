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
            int idGenerado = clsPropietario.guardar();
            return idGenerado;
        }

        public static void actualizar (int id_propietario, string razon_social, Int64 cuit, string telefono,
            string email, string persona_contacto) {
            Propietario p = new Propietario(id_propietario, razon_social, cuit, telefono, email, persona_contacto);
            p.guardar();
        }

        public static void eliminar(int id) {
            Propietario clsPropietario = new Propietario();
            clsPropietario.eliminarPorId(id);
        }

        public static DataTable? listarTodo() {
            Propietario clsPropietario = new Propietario();
            DataTable? propietarios = clsPropietario.obtenerTodos();
            return propietarios;
        }
        public static void encontrarPorIdRazonSocial(int id) {
            Propietario clsPropietario = new Propietario();
            clsPropietario.encontrarPorIdRazonSocial(id);
        }

        public static DataTable? buscarPorRazonSocial (string razonSocial) {
            Propietario clsPropietario = new Propietario();
            return clsPropietario.buscarPorRazonSocial(razonSocial);
        }




    }
}
