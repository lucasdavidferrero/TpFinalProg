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
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg {
    public partial class EmpleadoFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;
        public EmpleadoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listarEmpleados();
            btnEliminar.Enabled = false;
            txtLegajo.Enabled = false;
            dateFechaIngreso.MaxDate = DateTime.Now;
        }

        private void limpiarCampos() {
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            dateFechaIngreso.Value = DateTime.Now;
        }

        private void reiniciarFormulario() {
            limpiarCampos();
            this.idRowSeleccionado = -1;
            this.idRowSeleccionadoEliminar = -1;
            btnGuardar.Text = "Crear";
            txtLegajo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void listarEmpleados() {
            DataTable listadoEmpleados = Controlador.EmpleadoControlador.listarTodoTodo();
            dgvEmpleado.DataSource = listadoEmpleados;
        }

        // Si existe error, retorna true.
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;

            if (string.IsNullOrEmpty(txtNombre.Text)) {
                mensajeError += "- El nombre es obligatorio. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtApellido.Text)) {
                mensajeError += "- El apellido es obligatorio. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtCelular.Text) || !Validar.soloNumeros(txtCelular.Text)) {
                mensajeError += "- El Teléfono esta vacío o es inválido. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || !Validar.email(txtEmail.Text)) {
                mensajeError += "- El email esta vacío o tiene un formato inválido. \n";
                hayAlMenosUnError = true;
            }


            if (hayAlMenosUnError) {
                Mensaje.Error(mensajeError);
            }
            return hayAlMenosUnError;
        }

        private void btnObesrvacion_Click(object sender, EventArgs e) {
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

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (validarFrm()) {
                return;
            }
            DateTime fechaingreso = dateFechaIngreso.Value;
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (this.idRowSeleccionado < 0) {
                Controlador.EmpleadoControlador.crear(fechaingreso, nombre, apellido, celular, email);
                Mensaje.Correcto("Guardado Exitosamente");
            } else {
                int idEmp = Convert.ToInt32(dgvEmpleado.Rows[this.idRowSeleccionado].Cells["legajo"].Value);
                EmpleadoControlador.actualizar(idEmp, fechaingreso, nombre, apellido, celular, email);
                Mensaje.Correcto("Modificado Exitosamente");
            }

            listarEmpleados();
            reiniciarFormulario();
        }
        private void dgvEmpleado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvEmpleado.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvEmpleado.Rows[idRowSeleccionado].Cells;
            txtLegajo.Text = celdas["legajo"].Value.ToString();
            txtNombre.Text = celdas["nombre"].Value.ToString();
            txtApellido.Text = celdas["apellido"].Value.ToString();
            dateFechaIngreso.Value = Convert.ToDateTime(celdas["fecha_ingreso"].Value.ToString());
            txtEmail.Text = celdas["email"].Value.ToString();
            txtCelular.Text = celdas["celular"].Value.ToString();

            btnGuardar.Text = "Guardar cambios";
            txtLegajo.Enabled = false;
        }

        private void dgvEmpleado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }

        private void btnReiniciar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
        }


        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                if (Mensaje.Consulta("Estas seguro que quiere eliminar?")) {
                    int idEmpleado = Convert.ToInt32(dgvEmpleado.Rows[idRowSeleccionadoEliminar].Cells["legajo"].Value.ToString());
                    EmpleadoControlador.eliminar(idEmpleado);
                    Mensaje.Correcto("Eliminado Exitosamente");
                    reiniciarFormulario();
                    listarEmpleados();
                }
            }
        }
    }
}
