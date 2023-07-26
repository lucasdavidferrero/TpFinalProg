using PruebaTpFinal.Dominio.Mappers;
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

        public static DataTable? cargarCb() {
            DataTable? dt = ProyectoDataMapper.cargarCb();
            return dt;
        }

        public static DataTable? obtenerProyectosConEmpresa(bool esTerminado) {
            Proyecto clsProyecto = new Proyecto();
            return clsProyecto.obtenerProyectosConEmpresa(esTerminado);
        }


        public static DataTable? BusquedaProyecto(string nombreProyecto) {
            DataTable? dt = ProyectoDataMapper.BuscarProyectos(nombreProyecto);
            return dt;
        }

        public static DataTable? CalcularCostoYGradoDeAvance(int idProyecto) {
            DataTable? tareas = TareaDataMapper.encontrarPorIdProyecto(idProyecto);
            if (tareas != null) {
                DataTable dt = new DataTable();
                decimal costo_real = 0;
                int tareas_terminadas = 0;
                
                foreach (DataRow row in tareas.Rows) {
                    costo_real += Convert.ToDecimal(row["costo_real"]);
                    if (row["costo_real"] != null) {
                        tareas_terminadas++;
                    }
                }

                dt.Columns.Add("costo_real", typeof(decimal));
                dt.Columns.Add("avance", typeof(decimal));

                // Crear una nueva fila y asignar valores a las columnas
                DataRow newRow = dt.NewRow();
                newRow["costo_real"] = costo_real;
                newRow["avance"] = (tareas_terminadas / tareas.Rows.Count * 100);
                dt.Rows.Add(newRow);
                return dt;
            }
            return null;
        }
    }

   

}

