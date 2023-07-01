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
using TpFinalProg.Formularios;

namespace TpFinalProg {
    public partial class MenuFrm : Form {
        public MenuFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e) {
            EmpleadoFrm emp = new EmpleadoFrm();
            emp.Show();
        }

        private void btnPropietarios_Click_1(object sender, EventArgs e) {
            PropietarioFrm prop = new PropietarioFrm();
            prop.Show();
        }

        private void btnProyectos_Click_1(object sender, EventArgs e) {
            ProyectoFrm proy = new ProyectoFrm();
            proy.Show();
        }

        private void btnTareas_Click_1(object sender, EventArgs e) {
            MenuTareaFrm tareas = new MenuTareaFrm();
            tareas.Show();
        }
    }
}
