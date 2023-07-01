using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Proyecto {
        public int idProyecto { get; }

        public string nombre { get; set; }

        public float montoEstimado { get; }

        public int tiempoEstimado { get; }
        public int idPropietario { get; }
        public int nroLegajo { get; }

        public Proyecto(int idProyecto, string nombre, float montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
            this.idProyecto = idProyecto;
            this.nombre = nombre;
            this.montoEstimado = montoEstimado;
            this.tiempoEstimado = tiempoEstimado;
            this.idPropietario = idPropietario;
            this.nroLegajo = legajo;
        }
    }
}
