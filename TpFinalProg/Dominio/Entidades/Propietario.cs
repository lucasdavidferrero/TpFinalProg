using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;

namespace TpFinalProg.Dominio.Entidades {
    internal class Propietario {
        private int idPropietario { get; set; }
        public string razonSocial { get; }
        public string telefono { get; }
        public string email { get; }
        public long cuit { get; }
        public string personaContacto { get; }

        public Propietario() { }

        public Propietario(int id_propietario, string razon_social, long cuit, string telefono,
            string email, string persona_contacto) {
            idPropietario = id_propietario;
            razonSocial = razon_social;
            this.telefono = telefono;
            this.email = email;
            this.cuit = cuit;
            personaContacto = persona_contacto;
        }

        /* Los métodos guardar, en general serían así en todas las entidades. */
        public int save() {
            if (idPropietario == 0) {
                // TODO: Regla de negocio: Verificar que no exista un propietario con el CUIT que nos dan.
                int id = PropietarioDataMapper.insertNew(this);
                return id;
            }

            // Obtener Propietario y verificar q existe
            // Guardar cambios en la DB
            bool propietarioEncontrado = true; // crear funcion q haga select por id y retorne true/false
            if (propietarioEncontrado) {
                // UPDATE usando los nuevos atributos
                return idPropietario;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public DataTable getAll() {
            return PropietarioDataMapper.getAll();
        }

        public bool delete(int id) {
            // Verificar correctamente si existe propietario con el id.
            // UPDATE el campo baja de la db
            return true;
        }
    }
}
