using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Funcion {
        private int idFuncion { get; }
        private string descripcion { get; }
        private int baja { get; }

        public Funcion(int idFuncion, string descripcion, int baja) {
            this.idFuncion = idFuncion;
            this.descripcion = descripcion;
            this.baja = baja;
        }
    }
}
