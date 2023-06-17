using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Proyecto {
        private int idProyecto { get; }

        private string nombre { get; }

        private float montoEstimado { get; }

        private int tiempoEstimado { get; }
        private int idPropietario { get; }
        private int nroLegajo { get; }

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
