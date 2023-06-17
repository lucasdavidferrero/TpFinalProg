using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Tarea {
        private int idProyecto { get; }
        private int idTarea { get; }
        private string descripcion { get; }

        private int horasEstimadas { get; }
        private float costoEstimado { get; }
        private int horasReales { get; }
        private float costoReal { get; }
        private DateOnly fechaFinal { get; }

        public Tarea() { }

        public Tarea(int idProyecto, int idTarea, string descripcion, int horasEstimadas, float costoEstimado, int horasReales, float costoReal, DateOnly fechaFinal) {
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.descripcion = descripcion;
            this.horasEstimadas = horasEstimadas;
            this.costoEstimado = costoEstimado;
            this.horasReales = horasReales;
            this.costoReal = costoReal;
            this.fechaFinal = fechaFinal;
        }
    }
}
