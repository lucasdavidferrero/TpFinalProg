using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpFinalProg.Formularios {
    public partial class MenuTareaFrm : Form {
        public MenuTareaFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnABM_Click(object sender, EventArgs e) {
            TareaFrm tareas = new TareaFrm();
            tareas.Show();
        }

        private void btnAsignacionTarea_Click(object sender, EventArgs e) {
            AsignacionTareaFrm asigtareas = new AsignacionTareaFrm();
            asigtareas.Show();
        }

        private void btnListados_Click(object sender, EventArgs e) {

        }
    }
}
