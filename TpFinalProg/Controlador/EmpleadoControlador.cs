using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class EmpleadoControlador {

        public static int crear(DateTime fecha_ingreso, string nombre, string apellido,
           string celular, string email) {
            Empleado clsEmpleado = new Empleado(0, fecha_ingreso, nombre, apellido, celular, email);
            int idGenerado = clsEmpleado.guardar();
            return idGenerado;
        }

        public static void actualizar(int legajo, DateTime fecha_ingreso, string nombre, string apellido,
           string celular, string email) {
            Empleado em = new Empleado(legajo, fecha_ingreso, nombre, apellido, celular, email);
            em.guardar();
        }

        public static void eliminar(int id) {
            Empleado clsEmpleado = new Empleado();
            clsEmpleado.eliminarPorId(id);
        }

        public static DataTable listarTodo() {
            Empleado clsEmpleado = new Empleado();
            DataTable empleados = clsEmpleado.obtenerTodos();
            return empleados;
        }
    }
}
