using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Observacion {
        private int idObservacion { get; }
        private DateOnly fecha { get; }
        private string observacion { get; }
        private int nroLegajo { get; }

        public Observacion(int idObservacion, DateOnly fecha, string observacion, int legajo) {
            this.idObservacion = idObservacion;
            this.fecha = fecha;
            this.observacion = observacion;
            nroLegajo = legajo;
        }
    }
}
