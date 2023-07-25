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
    public partial class ListadoEmpleadoFrm : Form {
        public ListadoEmpleadoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void reiniciarInputs() {
            txtNombre.Text = "";
        }

        private bool almenosUnEmpleadoEncontrado(DataTable? dt, string txtBusqueda) {
            if (dt?.Rows.Count == 0) {
                Mensaje.Advertencia($"No encontramos ningún Empleado con la busqueda: {txtBusqueda}");
                return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            string nombre = txtNombre.Text.Trim();
            DataTable? empleadosDataTable = EmpleadoControlador.buscarPorNombre(nombre);
            if (almenosUnEmpleadoEncontrado(empleadosDataTable, nombre)) {
                dgvEmpleado.DataSource = empleadosDataTable;
                reiniciarInputs();
            }
        }
    }
}
