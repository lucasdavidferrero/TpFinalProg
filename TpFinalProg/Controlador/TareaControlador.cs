using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class TareaControlador {

        public static bool crear(int idProyecto, string descripcion, int horasEstimadas, int horasAvance, decimal costoEstimado, int horasReales, decimal costoReal) {
            int nroTareaCalculado = obtenerNuevoNroTarea(idProyecto);
            Tarea objTarea = new Tarea(idProyecto, nroTareaCalculado, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal);
            Tuple<int, int>? idGenerado = TareaDataMapper.insertarNuevo(objTarea);
            
            if (idGenerado == null ) {
                return false;
            }
            return true;
        }

        
        public static bool actualizar(int idProyecto, int idTarea, string descripcion, int horasEstimadas, int horasAvance, decimal costoEstimado, int horasReales, decimal costoReal) {
            Tarea t = new Tarea(idProyecto, idTarea, descripcion, horasEstimadas, horasAvance, costoEstimado, horasReales, costoReal);
            Tuple<int,int>? idModificado = TareaDataMapper.modificar(t);
            
            if (idModificado == null) {
                return false;
            } else {
                return true;
            }
            
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

        public static DataTable cargarDtv() {
            DataTable dt = TareaDataMapper.obtenerTodos();
            DataTable? deProyecto = ProyectoDataMapper.obtenerTodos();
            DataTable dtNuevo = new();
            dtNuevo.Columns.Add("id_proyecto", typeof(int));
            dtNuevo.Columns.Add("proyecto", typeof(string));
            dtNuevo.Columns.Add("nro_tarea", typeof(int));
            dtNuevo.Columns.Add("descripcion", typeof(string));
            dtNuevo.Columns.Add("horas_estimadas", typeof(int));
            dtNuevo.Columns.Add("costo_estimado", typeof(double));
            dtNuevo.Columns.Add("horas_reales", typeof(int));
            dtNuevo.Columns.Add("costo_real", typeof(double));
            dtNuevo.Columns.Add("fecha_final", typeof(DateTime));
            dtNuevo.Columns.Add("horas_avance", typeof(int));

            foreach (DataRow row in dt.Rows) {
                int idProyecto = Convert.ToInt32(row["id_proyecto"]);
                string? proyecto = deProyecto?.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["id_proyecto"]) == idProyecto)?["nombre"].ToString();
                int nroTarea = Convert.ToInt32(row["nro_tarea"]);
                string? descripcion = row["descripcion"].ToString();
                int horaEstimada = Convert.ToInt32(row["horas_estimadas"]);
                double costoEstimado = Convert.ToDouble(row["costo_estimado"]);
                int horaReal = Convert.ToInt32(row["horas_reales"]);
                double costoReal = Convert.ToDouble(row["costo_real"]);
                DateTime fechaFinal;
                if (Convert.IsDBNull(row["fecha_final"])) {
                    fechaFinal = new DateTime(1, 1, 1, 0, 0, 0);
                }
                else {
                    fechaFinal = Convert.ToDateTime(row["fecha_final"]);
                }

                
                int horasAvance = Convert.ToInt32(row["horas_avance"]);

                dtNuevo.Rows.Add(idProyecto, proyecto, nroTarea, descripcion, horaEstimada, costoEstimado, horaReal, costoReal, fechaFinal, horasAvance);
            }

            return dtNuevo;
        }

        private static int obtenerNuevoNroTarea(int idProyecto) {

            DataTable? dt = TareaDataMapper.obtenerUltimoIdTarea(idProyecto);

            if (dt == null) {
                return 1;
            }

            DataRow ultimaFila = dt.Rows[dt.Rows.Count - 1];
            // Aquí puedes acceder a los valores de las columnas de la última fila
            // Ejemplo:
            int ultimoNroTarea = Convert.ToInt32(ultimaFila["nro_tarea"]);
            return ultimoNroTarea + 1;
        }

        public static DataTable? cargarCbAsignacionTarea(int id_proyecto) {
            DataTable? dt = TareaDataMapper.encontrarPorIdProyecto(id_proyecto);
            return dt;
        }

        public static DataTable? BuscadorTareasPorProyecto(int idProyecto, string descripcionBusqueda) {
            DataTable? dt = TareaDataMapper.BuscadorTareasPorProyecto(idProyecto, descripcionBusqueda);
            return dt;
        }

        public static DataTable? obtenerTareasEnCursoPorIdProyeto (int idProyecto) {
            Tarea tareaCls = new Tarea();
            return tareaCls.obtenerTareasEnCursoPorIdProyeto(idProyecto);
        }

        public static DataTable? obtenerTareasFinalizadasPorIdProyeto (int idProyecto) {
            Tarea tareaCls = new Tarea();
            return tareaCls.obtenerTareasFinalizadasPorIdProyeto(idProyecto);
        }

    }   
}
