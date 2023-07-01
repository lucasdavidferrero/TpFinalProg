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
        public int guardar() {
            if (idPropietario == 0) {
                // TODO: Regla de negocio: Verificar que no exista un propietario con el CUIT que nos dan.
                int id = PropietarioDataMapper.insertarNuevo(this);
                return id;
            }

            Propietario propEncontrado = PropietarioDataMapper.encontrarPorId(this.idPropietario);
            if (propEncontrado != null) {
                PropietarioDataMapper.modificar(this);
                return idPropietario;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public DataTable obtenerTodos() {
            return PropietarioDataMapper.obtenerTodos();
        }

        public void eliminarPorId(int id) {
            PropietarioDataMapper.eliminar(id);
        }
    }
}
