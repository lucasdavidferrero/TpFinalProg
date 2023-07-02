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
        private int baja { get; }

        public Observacion(int idObservacion, DateOnly fecha, string observacion, int legajo, int baja) {
            this.idObservacion = idObservacion;
            this.fecha = fecha;
            this.observacion = observacion;
            this.nroLegajo = legajo;
            this.baja = baja;
        }
    }
}
