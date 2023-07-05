using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Trabaja {

        public int idTrabaja { get; }
        public int nroLegajo { get; }
        public int idProyecto { get; }
        public int idTarea { get; }
        public int idFuncion { get; set; }

        public Trabaja(int idTrabaja, int legajo, int idProyecto, int idTarea, int idFuncion) {
            this.idTrabaja = idTrabaja;
            this.nroLegajo = legajo;
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.idFuncion = idFuncion;
        }

        public Trabaja(int legajo, int idProyecto, int idTarea, int idFuncion) {
            this.nroLegajo = legajo;
            this.idProyecto = idProyecto;
            this.idTarea = idTarea;
            this.idFuncion = idFuncion;
        }
    }
}
