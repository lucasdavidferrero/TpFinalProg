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
            StartPosition = FormStartPosition.CenterScreen;
            listarPropietarios();
        }
        private void reiniciarInputs() {
            txtRazonSocial.Text = "";
            txtCuit.Text = "";
        }
        private void reiniciarDgv() {
            DataTable emptyDt = new DataTable();
            dgvPropietario.DataSource = emptyDt;
        }

        private void listarPropietarios() {
            DataTable? listadoPropietarios = Controlador.PropietarioControlador.listarTodo();
            dgvPropietario.DataSource = listadoPropietarios;
        }

        private bool almenosUnPropietarioEncontrado(DataTable? dt, string txtBusqueda) {
            if (dt?.Rows.Count == 0) {
                Mensaje.Advertencia($"No encontramos ningún Propietario con la busqueda: {txtBusqueda}");
                return false;
            }
            return true;
        }

        private void btnBuscarRazonSocial_Click(object sender, EventArgs e) {
            // TODO: Hacer input CUIT solo números
            reiniciarDgv();
            string razonSocial = txtRazonSocial.Text.Trim();
            DataTable? propietariosDataTable = PropietarioControlador.buscarPorRazonSocial(razonSocial);
            if (almenosUnPropietarioEncontrado(propietariosDataTable, razonSocial)) {
                dgvPropietario.DataSource = propietariosDataTable;
                reiniciarInputs();
            }
        }

        private void btnBuscarCuit_Click(object sender, EventArgs e) {
            reiniciarDgv();
            Int64 cuit = Convert.ToInt64(txtCuit.Text.Trim());
            DataTable? propietariosTable = PropietarioControlador.buscarPorCuit(cuit);
            if (almenosUnPropietarioEncontrado(propietariosTable, cuit.ToString())) {
                dgvPropietario.DataSource = propietariosTable;
                reiniciarInputs();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e) {
            listarPropietarios();
        }
    }
}
