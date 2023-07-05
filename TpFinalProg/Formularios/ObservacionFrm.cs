using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Controlador;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;
using static System.Windows.Forms.MonthCalendar;

namespace TpFinalProg {
    public partial class ObservacionFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;
        public ObservacionFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listarObservacion();
            cargarCbEmpleado();
        }
        private void cargarCbEmpleado() {
            DataTable? ta = Empleado.CargarCombo();
            cbEmpleado.DataSource = ta?.DefaultView;
            cbEmpleado.ValueMember = "legajo";
            cbEmpleado.DisplayMember = "descripcion";
        }

        private void limpiarCampos() {
            date.Value = DateTime.Now;
            txtObservacion.Text = "";
            cbEmpleado.Enabled = true;
            cargarCbEmpleado();

        }

        private void reiniciarFormulario() {
            limpiarCampos();
            this.idRowSeleccionado = -1;
            this.idRowSeleccionadoEliminar = -1;
            btnGuardar.Text = "Crear";
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void listarObservacion() {
            DataTable? listadoObservacion = Controlador.ObservacionControlador.listarTodoParametro();
            dgvObservacion.DataSource = listadoObservacion;
        }

        // Si existe error, retorna true.
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;

            if (cbEmpleado.SelectedIndex == 0) {
                mensajeError += "- Seleccione un Responsable. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtObservacion.Text)) {
                mensajeError += "- La Observacion esta vacía. \n";
                hayAlMenosUnError = true;
            }

            if (hayAlMenosUnError) {
                Mensaje.Error(mensajeError);
            }
            return hayAlMenosUnError;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (validarFrm()) {
                return;
            }
            DateTime fechaingreso = date.Value;
            string observacion = txtObservacion.Text.Trim();
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);

            if (this.idRowSeleccionado < 0) {
                Controlador.ObservacionControlador.crear(fechaingreso, observacion, legajo);
                Mensaje.Correcto("Guardado Exitosamente");
            } else {
                int idObs = Convert.ToInt32(dgvObservacion.Rows[this.idRowSeleccionado].Cells["ID"].Value);
                ObservacionControlador.actualizar(idObs, fechaingreso, observacion, legajo);
                Mensaje.Correcto("Modificado Exitosamente");
            }

            listarObservacion();
            reiniciarFormulario();
            cargarCbEmpleado();
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                if (Mensaje.Consulta("Estas seguro que quiere eliminar?")) {
                    int idObservacion = Convert.ToInt32(dgvObservacion.Rows[idRowSeleccionadoEliminar].Cells["ID"].Value.ToString());
                    ObservacionControlador.eliminar(idObservacion);
                    Mensaje.Correcto("Eliminado Exitosamente");
                    reiniciarFormulario();
                    listarObservacion();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
            listarObservacion();
        }

        private void dgvObservacion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvObservacion.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvObservacion.Rows[idRowSeleccionado].Cells;
            cbEmpleado.Text = celdas["column1"].Value.ToString();
            date.Value = Convert.ToDateTime(celdas["fecha"].Value.ToString());
            txtObservacion.Text = celdas["observacion"].Value.ToString();

            btnGuardar.Text = "Guardar cambios";
            cbEmpleado.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void dgvObservacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int legajo = Convert.ToInt32(cbEmpleado.SelectedValue);

            DataTable tareas = ObservacionDataMapper.encontrarPorIdint(legajo);
            dgvObservacion.DataSource = tareas;
        }


    }

}



