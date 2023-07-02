using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    public class Funcion {
        public int idFuncion { get; }
        public string descripcion { get; }

        public Funcion(int idFuncion, string descripcion) {
            this.idFuncion = idFuncion;
            this.descripcion = descripcion;
        }
    }
}
