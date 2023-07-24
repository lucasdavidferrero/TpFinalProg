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
    public partial class MenuPersonasFrm : Form {
        public MenuPersonasFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEmpleado_Click(object sender, EventArgs e) {
            ListadoEmpleadoFrm emp = new ListadoEmpleadoFrm();
            emp.Show();
        }

        private void btnPropietario_Click(object sender, EventArgs e) {
            // ListadoPropietarioFrm prop = new ListadoPropietarioFrm();
            // prop.Show();
        }
    }
}
