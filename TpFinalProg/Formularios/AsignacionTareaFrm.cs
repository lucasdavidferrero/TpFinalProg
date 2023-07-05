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
        private int idRowSeleccionadoEliminar = -1;
        public AsignacionTareaFrm() {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarTodo();
        }

        private void cargarCbProyecto() {

            DataTable proyectos = ProyectoControlador.obtenerProyectosActivosConTareasDisponiblesParaAsignar();
            cbProyecto.DataSource = proyectos;
            cbProyecto.DisplayMember = "proyecto_nombre";
            cbProyecto.ValueMember = "id_proyecto";
        }

        private void cargarCbTarea(int idProyecto) {
            DataTable tareas = TareaDataMapper.obtenerTareasActivasPorIdProyecto(idProyecto);
            cbTarea.DataSource = tareas;
            cbTarea.DisplayMember = "descripcion";
            cbTarea.ValueMember = "nro_tarea";
        }

        private void cargarCbEmpleado() {
            DataTable empleados = EmpleadoDataMapper.obtenerTodos();
            cbEmpleado.DataSource = empleados;
            cbEmpleado.DisplayMember = "nombreCompleto";
            cbEmpleado.ValueMember = "legajo";
        }

        private void cargarCbFuncion() {
            DataTable funciones = FuncionDataMapper.obtenerTodos();
            cbFuncion.DataSource = funciones;
            cbFuncion.DisplayMember = "descripcion";
            cbFuncion.ValueMember = "id_funcion";
        }


        private void cbProyecto_SelectedIndexChanged(object sender, EventArgs e) {
            cbTarea.Text = "";
            // Obtén el elemento seleccionado del ComboBox
            DataRowView selectedRow = cbProyecto.SelectedItem as DataRowView;

            if (selectedRow != null) {
                // Obtén el valor del elemento seleccionado
                int selectedId = Convert.ToInt32(selectedRow["id_proyecto"]);

                cargarCbTarea(selectedId);
            }

        }

        private void cargarDgvTarea() {
            DataTable dtRelacional = TrabajaControlador.cargarDgvTrabaja();
            dgvTarea.DataSource = dtRelacional;

        }

        private void guardarTarea() {
            int id_proyecto = Convert.ToInt32(cbProyecto.SelectedValue);
            int nro_tarea = Convert.ToInt32(cbTarea.SelectedValue);
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);
            int id_funcion = Convert.ToInt32(cbFuncion.SelectedValue);

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
            
            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvTarea.Rows[idRowSeleccionado].Cells;
            txtIdTrabaja.Text = celdas["id_trabaja"].Value.ToString();
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            cargarTodo();
        }

        private void seleccionarFila() {
            if (dgvTarea.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
    {
                // Obtiene los valores de los IDs de la fila seleccionada
                int idProyecto = Convert.ToInt32(dgvTarea.SelectedRows[0].Cells["id_proyecto"].Value);
                int idEmpleado = Convert.ToInt32(dgvTarea.SelectedRows[0].Cells["legajo"].Value);
                int idtarea = Convert.ToInt32(dgvTarea.SelectedRows[0].Cells["descripcion"].Value);
                int idFuncion = Convert.ToInt32(dgvTarea.SelectedRows[0].Cells["id_funcion_fk"].Value);

                // Selecciona los elementos correspondientes en los ComboBox
                cbProyecto.SelectedValue = idProyecto;
                cbTarea.SelectedValue = idtarea;
                cbEmpleado.SelectedValue = idEmpleado;
                cbFuncion.SelectedValue = idFuncion;
            }
        }

        private void dgvTarea_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (dgvTarea.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvTarea.Rows[idRowSeleccionado].Cells;

            txtIdTrabaja.Text = celdas["id_trabaja"].Value.ToString();
            cbProyecto.Text = celdas["nombre_proyecto"].Value.ToString();
            cbTarea.Text = celdas["descripcion"].Value.ToString();
            cbEmpleado.Text = celdas["nombre_empleado"].Value.ToString();
            cbFuncion.Text = celdas["nombre_funcion"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            int id_trabaja = Convert.ToInt32(txtIdTrabaja.Text.Trim());
            int id_proyecto = Convert.ToInt32(cbProyecto.SelectedValue);
            int nro_tarea = Convert.ToInt32(cbTarea.SelectedValue);
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);
            int id_funcion = Convert.ToInt32(cbFuncion.SelectedValue);

            TrabajaControlador.modificar(id_trabaja, id_proyecto, nro_tarea, legajo, id_funcion);

            cargarDgvTarea();
            cargarTodo();
            */
        }
    }
}
