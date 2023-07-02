using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    public class Observacion {
        public int idObservacion { get; }
        public DateTime fecha { get; }
        public string observacion { get; }
        public int nroLegajo { get; }

        public Observacion(int idObservacion, DateTime fecha, string observacion, int legajo) {
            this.idObservacion = idObservacion;
            this.fecha = fecha;
            this.observacion = observacion;
            nroLegajo = legajo;
        }
    }
}
