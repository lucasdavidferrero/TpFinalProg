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
    public partial class MenuListadoFrm : Form {
        public MenuListadoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEmpleados_Click(object sender, EventArgs e) {
            ListadoEmpleadoFrm emp = new ListadoEmpleadoFrm();
            emp.Show();
        }

        private void btnResponsable_Click(object sender, EventArgs e) {
            ListadoResponsableFrm res = new ListadoResponsableFrm();
            res.Show();
        }

        private void btnPropietarios_Click(object sender, EventArgs e) {
            ListadoPropietarioFrm prop = new ListadoPropietarioFrm();
            prop.Show();
        }
    }
}
