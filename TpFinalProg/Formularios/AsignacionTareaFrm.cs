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
using TpFinalProg.Controlador;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TpFinalProg {
    public partial class AsignacionTareaFrm : Form {
        private int idRowSeleccionado = -1;
        //private int idRowSeleccionadoEliminar = -1;
        public AsignacionTareaFrm() {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarTodo();

        }

        private void cargarCbProyecto() {

            DataTable? proyectos = ProyectoControlador.cargarCb();
            cbProyecto.DataSource = proyectos;
            cbProyecto.DisplayMember = "nombre";
            cbProyecto.ValueMember = "id_proyecto";
        }

        private void cargarCbTarea(int idProyecto) {
            DataTable? tareas = TareaControlador.cargarCbAsignacionTarea(idProyecto);
            cbTarea.DataSource = tareas;
            cbTarea.DisplayMember = "descripcion";
            cbTarea.ValueMember = "nro_tarea";
        }

        private void cargarCbEmpleado() {
            DataTable? empleados = EmpleadoControlador.cargarCb();
            cbEmpleado.DataSource = empleados;
            cbEmpleado.DisplayMember = "nombreCompleto";
            cbEmpleado.ValueMember = "legajo";
        }

        private void cargarCbFuncion() {
            DataTable? funciones = FuncionControlador.cargarCb();
            cbFuncion.DataSource = funciones;
            cbFuncion.DisplayMember = "descripcion";
            cbFuncion.ValueMember = "id_funcion";
        }


        private void cbProyecto_SelectedIndexChanged(object sender, EventArgs e) {
            cbTarea.Text = "";
            // Obtén el elemento seleccionado del ComboBox
            DataRowView? selectedRow = cbProyecto.SelectedItem as DataRowView;

            if (selectedRow != null) {
                // Obtén el valor del elemento seleccionado
                int selectedId = Convert.ToInt32(selectedRow["id_proyecto"]);

                cargarCbTarea(selectedId);
            }

        }

        private void cargarDgvTarea() {
            DataTable? dtRelacional = TrabajaControlador.cargarDgvTrabaja();
            dgvTarea.DataSource = dtRelacional;

        }

        private void guardarTarea() {
            int id_proyecto = Convert.ToInt32(cbProyecto.SelectedValue);
            int nro_tarea = Convert.ToInt32(cbTarea.SelectedValue);
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);
            int id_funcion = Convert.ToInt32(cbFuncion.SelectedValue);

            if (id_proyecto == 0 || nro_tarea == 0 || legajo == 0 || id_funcion == 0) {
                MessageBox.Show("Error, todos los campos son obligatorios...");
                return;
            }

            TrabajaControlador.guardar(id_proyecto, nro_tarea, legajo, id_funcion);

            cargarDgvTarea();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            guardarTarea();
            cargarDgvTarea();
        }

        private bool mensajeDeELiminacion() {
            // Mostrar ventana de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la asignación de tarea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes) {
                // Usuario ha confirmado, realizar la eliminación
                return true;
            } else if (result == DialogResult.No) {
                // Usuario ha cancelado, no hacer nada
                // Opcional: Puedes mostrar un mensaje de cancelación
                MessageBox.Show("La eliminación de la asignación de tarea ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }

        private void btnBorrar_Click(object sender, EventArgs e) {

            if (mensajeDeELiminacion()) {
                int id_trabaja = Convert.ToInt32(txtIdTrabaja.Text.Trim());
                TrabajaControlador.eliminar(id_trabaja);
                cargarDgvTarea();
            }
        }

        private void cargarTodo() {
            cargarCbProyecto();
            cargarCbEmpleado();
            cargarCbFuncion();
            cargarDgvTarea();
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            cargarTodo();
        }



        private void dgvTarea_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (dgvTarea.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvTarea.Rows[idRowSeleccionado].Cells;

            txtIdTrabaja.Text = celdas["id_trabaja"].Value.ToString();
            cbProyecto.Text = celdas["nombre"].Value.ToString();
            cbTarea.Text = celdas["descripcionTarea"].Value.ToString();
            cbEmpleado.Text = celdas["nombreCompleto"].Value.ToString();
            cbFuncion.Text = celdas["descripcionFuncion"].Value.ToString();
        }


        private void dgvTarea_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;

            if (dgvTarea.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvTarea.Rows[idRowSeleccionado].Cells;

            txtIdTrabaja.Text = celdas["id_trabaja"].Value.ToString();
        }

        
    }
}
