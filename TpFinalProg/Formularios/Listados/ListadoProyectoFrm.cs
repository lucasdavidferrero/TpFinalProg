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

namespace TpFinalProg.Formularios.Listados {
    public partial class ListadoProyectoFrm : Form {
        public ListadoProyectoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarDgvTerminados();
            cargarDgvNoTerminados();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

        }


        private void cargarDgvTerminados() {
            dgvTerminados.DataSource = ProyectoControlador.obtenerProyectosConEmpresa(true);
        }

        private void cargarDgvNoTerminados() {
            dvgNoTerminados.DataSource = ProyectoControlador.obtenerProyectosConEmpresa(false);
        }
    }
}
