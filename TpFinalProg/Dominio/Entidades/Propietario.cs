using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;

namespace TpFinalProg.Dominio.Entidades {
    internal class Propietario {
        public int idPropietario { get; set; }
        public string razonSocial { get; }
        public string telefono { get; }
        public string email { get; }
        public long cuit { get; }
        public string personaContacto { get; }

        public Propietario() { }

        public Propietario(int id_propietario, string razon_social, Int64 cuit, string telefono,
            string email, string persona_contacto) {
            idPropietario = id_propietario;
            razonSocial = razon_social;
            this.telefono = telefono;
            this.email = email;
            this.cuit = cuit;
            personaContacto = persona_contacto;
        }
        public int save() {
            if (idPropietario == 0) {
                // TODO: Regla de negocio: Verificar que no exista un propietario con el CUIT que nos dan.
                int id = PropietarioDataMapper.insertNew(this);
                return id;
            }

            Propietario propEncontrado = PropietarioDataMapper.findById(this.idPropietario);
            if (propEncontrado != null) {
                PropietarioDataMapper.update(this);
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
