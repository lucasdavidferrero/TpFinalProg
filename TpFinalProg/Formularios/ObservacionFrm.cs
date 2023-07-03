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
using TpFinalProg.Utilidades;

namespace TpFinalProg {
    public partial class ObservacionFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;
        public ObservacionFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listarObservacion();
        }

        private void limpiarCampos() {
            txtLegajo.Text = "";
            date.Value = DateTime.Now;
            txtObservacion.Text = "";
        }

        private void reiniciarFormulario() {
            limpiarCampos();
            this.idRowSeleccionado = -1;
            this.idRowSeleccionadoEliminar = -1;
            txtLegajo.Enabled = true;
            btnGuardar.Text = "Crear";
            btnEliminar.Enabled = false;
        }

        private void listarObservacion() {
            DataTable listadoObservacion = Controlador.ObservacionControlador.listarTodo();
            dgvObservacion.DataSource = listadoObservacion;
        }

        // Si existe error, retorna true.
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;

            if (string.IsNullOrEmpty(txtLegajo.Text)) {
                mensajeError += "- El legajo esta vacío o es inválido. \n";
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
            int legajo = Convert.ToInt32(txtLegajo.Text.Trim());


            if (this.idRowSeleccionado < 0) {
                Controlador.ObservacionControlador.crear(fechaingreso, observacion, legajo);
            } else {
                int idObs = Convert.ToInt32(dgvObservacion.Rows[this.idRowSeleccionado].Cells["ID"].Value);
                ObservacionControlador.actualizar(idObs, fechaingreso, observacion, legajo);
            }

            listarObservacion();
            reiniciarFormulario();
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                int idObservacion = Convert.ToInt32(dgvObservacion.Rows[idRowSeleccionadoEliminar].Cells["ID"].Value.ToString());
                ObservacionControlador.eliminar(idObservacion);
                reiniciarFormulario();
                listarObservacion();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int id =Convert.ToInt32(txtLegajo.Text.Trim());
             ObservacionDataMapper.encontrarLegajo(id);
           // dgvObservacion.DataSource = trabaja;

        }

        private void dgvObservacion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvObservacion.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvObservacion.Rows[idRowSeleccionado].Cells;
            txtLegajo.Text = celdas["legajo"].Value.ToString();
            date.Value = Convert.ToDateTime(celdas["fecha"].Value.ToString());
            txtObservacion.Text = celdas["observacion"].Value.ToString();


            btnGuardar.Text = "Guardar cambios";
            txtLegajo.Enabled = false;
        }

        private void dgvObservacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }
    }
}
