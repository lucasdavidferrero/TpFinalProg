using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Entidades {
    internal class Propietario {
        private int idPropietario { get; set; }
        private string razonSocial { get; }
        private string telefono { get; }
        private string email { get; }
        private Int64 cuit { get; }
        private string personaContacto { get; }

        public Propietario() { }

        public Propietario(int id_propietario, string razon_social, Int64 cuit, string telefono,
            string email, string persona_contacto) {
            this.idPropietario = id_propietario;
            this.razonSocial = razon_social;
            this.telefono = telefono;
            this.email = email;
            this.cuit = cuit;
            this.personaContacto = persona_contacto;
        }

        /* Los métodos guardar, en general serían así en todas las entidades. */
        public int save () {
            if (this.idPropietario == 0) {
                // Insert en DB...

                this.idPropietario = 234234234; // Guardar ID generado.
                return this.idPropietario;
            }
            // Obtener Propietario y verificar q existe
            // Guardar cambios en la DB
            bool propietarioEncontrado = true; // crear funcion q haga select por id y retorne true/false
            if (propietarioEncontrado) {
                // UPDATE usando los nuevos atributos
                return this.idPropietario;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public List<Propietario> getAll () {
            return null;
        }

        public bool delete (int id) {
            // Verificar correctamente si existe propietario con el id.
            // UPDATE el campo baja de la db
            return true;
        }
    }
}
