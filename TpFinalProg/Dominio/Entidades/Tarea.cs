using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Dominio.Entidades {
    internal class Tarea {
        public int idProyecto { get; }
        public int idTarea { get; }
        public string? descripcion { get; set; }

        public int horasEstimadas { get; }

        public int horasAvance { get; }
        public decimal costoEstimado { get; }
        public int horasReales { get; }
        public decimal costoReal { get; }
        public DateTime fechaFinal { get; }

        public Tarea() {

        }

        public Tarea(int idProyecto, int idTarea, string? descripcion, int horasEstimadas, int horasAvance, decimal costoEstimado, int horasReales, decimal costoReal, DateTime fechaFinal) {
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.descripcion = descripcion;
            this.horasEstimadas = horasEstimadas;
            this.horasAvance = horasAvance;
            this.costoEstimado = costoEstimado;
            this.horasReales = horasReales;
            this.costoReal = costoReal;
            this.fechaFinal = fechaFinal;
        }

        public Tarea(int idProyecto, int idTarea, string descripcion, int horasEstimadas, int horasAvance, decimal costoEstimado, int horasReales, decimal costoReal) {
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.descripcion = descripcion;
            this.horasEstimadas = horasEstimadas;
            this.horasAvance = horasAvance;
            this.costoEstimado = costoEstimado;
            this.horasReales = horasReales;
            this.costoReal = costoReal;
        }



        public DataTable obtenerTodos() {
            return TareaDataMapper.obtenerTodos();
        }
        
        public void eliminarPorId(int idProyecto, int idTarea) {
            TareaDataMapper.eliminar(idProyecto, idTarea);
        }

        public static DataTable? CargarCombo() {
            DataSet? ds = TareaDataMapper.cargarCombo();
            DataTable? dtListaAll = null;
            if (ds != null) {
                dtListaAll = ds.Tables[0];

            } else {
                Mensaje.Error("No hay datos de proyecto en BD");
            }
            return dtListaAll;

        }

        public DataTable? obtenerTareasEnCursoPorIdProyeto(int idProyecto) {
            return TareaDataMapper.obtenerTareasEnCursoPorIdProyeto(idProyecto);
        }

    }
}
