using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Empleado {
        public int nroLegajo { get; }
        public DateOnly fechaIngreso { get; }
        public string nombre { get; }
        public string apellido { get; }
        public string celular { get; }
        public string email { get; }

        public bool baja { get; }

        public Empleado(int legajo, DateOnly fechaIngreso, string nombre, string apellido, string celular, string email) {
            this.nroLegajo = legajo;
            this.fechaIngreso = fechaIngreso;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.email = email;
        }

        public Empleado(DateOnly fechaIngreso, string nombre, string apellido, string celular, string email) {
            this.fechaIngreso = fechaIngreso;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.email = email;
        }
    }
}
