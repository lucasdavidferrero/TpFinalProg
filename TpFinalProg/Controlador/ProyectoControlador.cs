using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class ProyectoControlador {

         public static int crear(string nombre, decimal montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
             Proyecto clsProyecto = new Proyecto(0, nombre, montoEstimado , tiempoEstimado, idPropietario, legajo);
             int idGenerado = clsProyecto.guardar();
             return idGenerado;
         }

        public static void actualizar(int id_proyecto, string nombre, decimal montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
             Proyecto p = new Proyecto(id_proyecto, nombre, montoEstimado, tiempoEstimado,  idPropietario, legajo);
             p.guardar();
         }

         public static void eliminar(int id) {
            Proyecto clsProyecto = new Proyecto();
            clsProyecto.eliminarPorId(id);
         }

         public static DataTable? listarTodo() {
            Proyecto clsProyecto = new Proyecto();
             DataTable? proyectos = clsProyecto.obtenerTodos();
             return proyectos;
         }

        public static DataTable? listarTodoParametro() {
            Proyecto clsProyecto = new Proyecto();
            DataTable? proyectos = clsProyecto.obtenerTodosParametros();
            return proyectos;
        }

        public static DataTable? obtenerProyectosActivosConTareasDisponiblesParaAsignar () {
            Proyecto clsProyecto = new Proyecto();
            return clsProyecto.obtenerProyectosActivosConTareasDisponiblesParaAsignar();
        }

    }

   

}

