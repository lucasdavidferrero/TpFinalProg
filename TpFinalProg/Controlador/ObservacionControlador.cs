using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class ObservacionControlador {

        public static int crear(DateTime fecha, string observacion, int legajo) {
            Observacion clsObservacion = new Observacion(0, fecha, observacion, legajo);
            int idGenerado = clsObservacion.guardar();
            return idGenerado;
        }

        public static void actualizar(int id_observacion ,DateTime fecha, string observacion, int legajo) {
            Observacion ob = new Observacion(id_observacion,fecha,observacion,legajo);
            ob.guardar();
        }

        public static void eliminar(int id) {
            Observacion clsObservacion = new Observacion();
            clsObservacion.eliminarPorId(id);
        }

        public static DataTable listarTodo() {
            Observacion clsObservacion = new Observacion();
            DataTable Observacion = clsObservacion.obtenerTodos();
            return Observacion;
        }
        public static DataTable listarTodoParametro() {
            Observacion clsObservacion = new Observacion();
            DataTable Observaciones = clsObservacion.obtenerTodosParametros();
            return Observaciones;
        }
    }
}
