using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpFinalProg
{
    public partial class ProyectoFrm : Form
    {
        public ProyectoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropietarioFrm prop = new PropietarioFrm();
            prop.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
