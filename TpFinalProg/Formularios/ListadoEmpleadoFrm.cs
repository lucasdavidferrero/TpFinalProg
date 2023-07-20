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

namespace TpFinalProg.Formularios {
    public partial class ListadoEmpleadoFrm : Form {
        public ListadoEmpleadoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ListarEmpleados();
            cargarCbEmpleado();
        }
        private void cargarCbEmpleado() {
            DataTable? ta = Empleado.CargarCombo();
            cbEmpleado.DataSource = ta?.DefaultView;
            cbEmpleado.ValueMember = "legajo";
            cbEmpleado.DisplayMember = "descripcion";
        }
        private void ListarEmpleados() {
            DataTable ListarEmpleados = Controlador.EmpleadoControlador.listarTodo();
            dataGridView1.DataSource = ListarEmpleados;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            cargarCbEmpleado();
            ListarEmpleados();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);

            DataTable tareas = EmpleadoDataMapper.encontrarPorIdint(legajo);
            dataGridView1.DataSource = tareas;
        }
    }
}
