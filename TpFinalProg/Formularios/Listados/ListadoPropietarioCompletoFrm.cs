using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Controlador;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Formularios.Listados {
    public partial class ListadoPropietarioCompletoFrm : Form {
        public ListadoPropietarioCompletoFrm() {
            InitializeComponent();
        }
        private void reiniciarInputs() {
            txtRazonSocial.Text = "";
        }

        private bool almenosUnPropietarioEncontrado(DataTable? dt, string txtBusqueda) {
            if (dt?.Rows.Count == 0) {
                Mensaje.Advertencia($"No encontramos ningún Propietario con la busqueda: {txtBusqueda}");
                return false;
            }
            return true;
        }

        private void btnBuscarRazonSocial_Click(object sender, EventArgs e) {
            string razonSocial = txtRazonSocial.Text.Trim();
            DataTable? propietariosDataTable = PropietarioControlador.buscarPorRazonSocial(razonSocial);
            if (almenosUnPropietarioEncontrado(propietariosDataTable, razonSocial)) {
                dgvPropietario.DataSource = propietariosDataTable;
                reiniciarInputs();
            }
        }

        private void btnBuscarCuit_Click(object sender, EventArgs e) {
            // TODO: Hacer input CUIT solo números. Si cuit vacío mostrar error.
            Int64 cuit = Convert.ToInt64(txtCuit.Text.Trim());
            DataTable? propietariosTable = PropietarioControlador.buscarPorCuit(cuit);
            if (almenosUnPropietarioEncontrado(propietariosTable, cuit.ToString())) {
                dgvPropietario.DataSource = propietariosTable;
                reiniciarInputs();
            }
        }
    }
}
