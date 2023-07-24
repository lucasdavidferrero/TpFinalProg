using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Formularios.Listados;

namespace TpFinalProg.Formularios {
    public partial class MenuListadosFrm : Form {
        public MenuListadosFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnListadoTareasPorProyecto_Click(object sender, EventArgs e) {

        }

        private void btnListadoPersonas_Click(object sender, EventArgs e) {
            MenuPersonasFrm per = new MenuPersonasFrm();
            per.Show();
        }

        private void btnPropietariosPorProyecto_Click(object sender, EventArgs e) {
            ListadoPropietarioCompletoFrm listadoPropietario = new ListadoPropietarioCompletoFrm();
            listadoPropietario.Show();
        }
    }
}
