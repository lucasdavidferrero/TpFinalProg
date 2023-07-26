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
            // cargarDgvTerminados(ProyectoControlador.BusquedaProyecto(""));
            cargarDgvNoTerminados();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

        }


        private void cargarDgvTerminados(DataTable dt) {

        }

        private void cargarDgvNoTerminados() {
            dvgNoTerminados.DataSource = ProyectoControlador.obtenerProyectosSinFinalizarConEmpresa();
        }
    }
}
