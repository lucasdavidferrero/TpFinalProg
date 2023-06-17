using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Entidades {
    internal class Funcion {
        private int idFuncion { get; }
        private string descripcion { get; }

        public Funcion(int idFuncion, string descripcion) {
            this.idFuncion = idFuncion;
            this.descripcion = descripcion;
        }
    }
}
