using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Tarea {
        public int idProyecto { get; }
        public int idTarea { get; }
        public string descripcion { get; set; }

        public int horasEstimadas { get; }

        public int horasAvance { get; }
        public float costoEstimado { get; }
        public int horasReales { get; }
        public float costoReal { get; }
        public DateTime fechaFinal { get; }

        public Tarea() { }

        public Tarea(int idProyecto, int idTarea, string descripcion, int horasEstimadas, int horasAvance, float costoEstimado, int horasReales, float costoReal, DateTime fechaFinal) {
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
    }
}
