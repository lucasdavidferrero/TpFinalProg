using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class TareaControlador {

        public static int crear (int idProyecto, int idTarea, string descripcion, int horasEstimadas, int horasAvance, float costoEstimado, int horasReales, float costoReal, DateTime fechaFinal) {
            Tarea clsTarea = new Tarea(idProyecto, idTarea, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal, fechaFinal);
            int idGenerado = clsTarea.guardar();
            return idGenerado;
        }

        public static void actualizar(int idProyecto, int idTarea, string descripcion, int horasEstimadas, int horasAvance, float costoEstimado, int horasReales, float costoReal, DateTime fechaFinal) {
            Tarea t = new Tarea(idProyecto, idTarea, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal, fechaFinal);
            t.guardar();
        }

        public static void eliminar(int idProyecto, int idTarea) {
            Tarea clsTarea = new Tarea();
            clsTarea.eliminarPorId(idProyecto, idTarea);
        }

        public static DataTable listarTodo() {
            Tarea clsTarea = new Tarea();
            DataTable tareas = clsTarea.obtenerTodos();
            return tareas;
        }

        public static DataTable listarTodoParametro() {
            Tarea clsTarea = new Tarea();
            DataTable tareas = clsTarea.obtenerTodos();
            return tareas;
        }

    }
}
