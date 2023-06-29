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

namespace TpFinalProg {
    public partial class MenuFrm : Form {
        public MenuFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEmpleados_Click(object sender, EventArgs e) {
            EmpleadoFrm emp = new EmpleadoFrm();
            emp.Show();
        }

        private void btnPropietarios_Click(object sender, EventArgs e) {
            PropietarioFrm prop = new PropietarioFrm();
            prop.Show();
        }

        private void btnProyectos_Click(object sender, EventArgs e) {
            ProyectoFrm proy = new ProyectoFrm();
            proy.Show();
        }

        private void btnTareas_Click(object sender, EventArgs e) {
            TareaFrm tar = new TareaFrm();
            tar.Show();

        }

        private void btnAsigTarea_Click(object sender, EventArgs e) {
            AsignacionTareaFrm asig = new AsignacionTareaFrm();
            asig.Show();
        }

        private void btnListado_Click(object sender, EventArgs e) {

        }
    }
}
