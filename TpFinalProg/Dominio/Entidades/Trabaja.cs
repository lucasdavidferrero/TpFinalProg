using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Trabaja {
        private int nroLegajo { get; }
        private int idProyecto { get; }
        private int idTarea { get; }
        private int idFuncion { get; }

        public Trabaja(int legajo, int idProyecto, int idTarea, int idFuncion) {
            this.nroLegajo = legajo;
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.idFuncion = idFuncion;
        }
    }
}
