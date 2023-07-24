using PruebaTpFinal.Dominio.Mappers;
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
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Formularios {
    public partial class ListadoPropietarioFrm : Form {
        public ListadoPropietarioFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void reiniciarInputs() {
            txtRazonSocial.Text = "";
        }
        private void reiniciarDgv () {
            dgvPropietario.DataSource = null;
        }

        private bool almenosUnPropietarioEncontrado (DataTable? dt, string txtBusqueda) {
            if (dt?.Rows.Count == 0) {
                Mensaje.Advertencia($"No encontramos ningún Propietario con la busqueda: {txtBusqueda}");
                return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            reiniciarDgv();
            string razonSocial = txtRazonSocial.Text.Trim();
            DataTable? propietariosDataTable = PropietarioControlador.buscarPorRazonSocial(razonSocial);
            if (almenosUnPropietarioEncontrado(propietariosDataTable, razonSocial)) {
                dgvPropietario.DataSource = propietariosDataTable;
                reiniciarInputs();
            }
        }

        private void btnBuscarCuit_Click(object sender, EventArgs e) {
            // Int64 cuit = Convert.ToInt64(txtNombre.Text.Trim());
            // DataTable prop = PropietarioDataMapper.encontrarPorCuitNoBaja(cuit);
            // dgvPropietario.DataSource = prop;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

       
    }
}

