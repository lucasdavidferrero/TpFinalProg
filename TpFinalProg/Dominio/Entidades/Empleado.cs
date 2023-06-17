using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    internal class Empleado {
        private int nroLegajo { get; }
        private DateOnly fechaIngreso { get; }
        private string nombre { get; }
        private string apellido { get; }
        private string celular { get; }
        private string email { get; }

        private bool baja { get; }

        public Empleado(int legajo, DateOnly fechaIngreso, string nombre, string apellido, string celular, string email) {
            nroLegajo = legajo;
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
