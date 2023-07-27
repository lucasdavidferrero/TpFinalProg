using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;

namespace TpFinalProg.Formularios.Listados {
    public partial class ListadoResponsableFrm : Form {
        public ListadoResponsableFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarCbEmpleado();
        }
        private void cargarCbEmpleado() {
            DataTable? ta = Empleado.CargarCombo();
            cbResponsable.DataSource = ta?.DefaultView;
            cbResponsable.ValueMember = "legajo";
            cbResponsable.DisplayMember = "descripcion";
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int legajo = Convert.ToInt32(cbResponsable.SelectedValue);

            DataTable externo = EmpleadoDataMapper.encontrarPorResponsableExterno(legajo);
            dgvExterno.DataSource = externo;

            DataTable interno = EmpleadoDataMapper.encontrarPorResponsableInterno(legajo);
            dgvInterno.DataSource = interno;
        }
    }
}
