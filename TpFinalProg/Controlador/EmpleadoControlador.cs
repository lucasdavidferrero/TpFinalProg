using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;

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

        public static DataTable listarTodoTodo() {
            Empleado clsEmpleado = new Empleado();
            DataTable empleados = clsEmpleado.obtenerTodosTodos();
            return empleados;
        }

        public static DataTable listarPorId(int id) {
            Empleado empleado = EmpleadoDataMapper.encontrarPorId(id);
            DataTable dt = new DataTable();
            dt.Columns.Add("legajo", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("apellido", typeof(string));
            dt.Columns.Add("email", typeof(int));
            dt.Columns.Add("celular", typeof(string));
            dt.Columns.Add("fecha_ingreso", typeof(string));
            dt.Columns.Add("nombreCompleto", typeof(string));



            DataRow row = dt.NewRow();
            row["legajo"] = empleado.legajo;
            row["nombre"] = empleado.nombre;
            row["apellido"] = empleado.apellido;
            row["email"] = empleado.email;
            row["celular"] = empleado.celular;
            row["fecha_ingreso"] = empleado.fechaIngreso.ToString();
            row["nombreCompleto"] = empleado.nombre + " " + empleado.apellido;


            dt.Rows.Add(row);
            return dt;
        }
    }
}
