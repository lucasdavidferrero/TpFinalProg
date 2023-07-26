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
            cargarDgvTerminados(ProyectoControlador.BusquedaProyecto(""));
            cargarDgvNoTerminados(ProyectoControlador.BusquedaProyecto(""));

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            String nombre = txtNombre.Text.Trim();
            DataTable? proyectos = ProyectoControlador.BusquedaProyecto(nombre);
            if (proyectos != null) {
                cargarDgvTerminados(proyectos);
            }

        }


        private void cargarDgvTerminados(DataTable dt) {
            if (dt != null) {
                dgvTerminados.DataSource = dt;
            }
        }

        private void cargarDgvNoTerminados(DataTable dt) {
            if (dt != null) {
                dvgNoTerminados.DataSource = dt;
            }
        }
    }
}
