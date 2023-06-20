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
    public partial class EmpleadoFrm : Form
    {
        public EmpleadoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnObservacion_Click(object sender, EventArgs e)
        {
            Form frm_observacion = Application.OpenForms.OfType<Form>().
                            Where(pre => pre.Name == "ObservacionFrm").SingleOrDefault();

            if (frm_observacion != null) {
                frm_observacion.Select();
                frm_observacion.WindowState = FormWindowState.Normal;
                frm_observacion.Show();
            } else {
                ObservacionFrm frm_observaciones = new ObservacionFrm();
                frm_observaciones.Show();
            }
        }


    }
}
