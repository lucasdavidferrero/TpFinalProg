﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Controlador;
using TpFinalProg.Utilidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Dominio;

namespace TpFinalProg {
    public partial class TareaFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;
        public TareaFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            cargarCbProyecto();
            listarTarea();
            btnEliminar.Enabled = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e) {
            if (validarFrm()) {
                return;
            }
            int idProyecto = Convert.ToInt32(cbProyecto.SelectedValue);
            int idTarea = Convert.ToInt32(txtNumero.Text.Trim());
            string descripcion = txtDescripcion.Text.Trim();
            int horasEstimadas = Convert.ToInt32(txtHoraEstimada.Text.Trim());
            int horasAvance = Convert.ToInt32(txtHoraAvance.Text.Trim());
            decimal costoEstimado = Convert.ToDecimal(txtCostoEstimado.Text.Trim());
            int horasReales = Convert.ToInt32(txtHoraReal.Text.Trim());
            decimal costoReal = Convert.ToDecimal(txtCostoReal.Text.Trim());
            //Ver si falta fecha
        }


        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;

            if (cbProyecto.SelectedIndex == 0) {
                mensajeError += "- Seleccione un Proyecto a asignar la tarea. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtNumero.Text)) {
                mensajeError += "- Debe ingresar número de tarea. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text)) {
                mensajeError += "- Descripción es obligatoria. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtHoraEstimada.Text) || !Validar.soloNumeros(txtHoraEstimada.Text)) {
                mensajeError += "- Horas estimada vacía o el dato es inválido. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtHoraAvance.Text) || !Validar.soloNumeros(txtHoraAvance.Text)) {
                mensajeError += "- Horas avance vacía o el dato es inválido. \n";
                hayAlMenosUnError = true;
            }
            if (string.IsNullOrEmpty(txtCostoEstimado.Text)) {
                mensajeError += "- El Monto estimado está vacío. \n";
                hayAlMenosUnError = true;
            }

            if (hayAlMenosUnError) {
                Mensaje.Error(mensajeError);
            }
            return hayAlMenosUnError;
        }

        private void limpiarCampos() {
            txtNumero.Text = "";
            txtHoraEstimada.Text = "";
            txtDescripcion.Text = "";
            txtCostoEstimado.Text = "";
            txtHoraReal.Text = "";
            txtCostoReal.Text = "";
            txtHoraAvance.Text = "";

        }

        private void reiniciarFormulario() {
            limpiarCampos();
            // this.idRowSeleccionado = -1;
            // this.idRowSeleccionadoEliminar = -1;
            btnGuardar.Text = "Crear";
            btnEliminar.Enabled = false;
        }

        private void listarTarea() {
            DataTable listadoTarea = Controlador.TareaControlador.listarTodo();
            dgvTarea.DataSource = listadoTarea;
        }

        private void cargarCbProyecto() {
            DataTable ta = Tarea.CargarCombo();
            cbProyecto.DataSource = ta.DefaultView;
            cbProyecto.ValueMember = "id_proyecto";
            cbProyecto.DisplayMember = "nombre";
        }
        public static DataTable CargarCombo() {
            DataSet ds = PropietarioDataMapper.cargarCombo();
            DataTable dtListaAll = null;
            if (ds != null) {
                dtListaAll = ds.Tables[0];

            } else {
                Mensaje.Error("No hay datos para de categoria");
            }
            return dtListaAll;

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                int id_proyecto = Convert.ToInt32(dgvTarea.Rows[idRowSeleccionadoEliminar].Cells["PROYECTO"].Value.ToString());
                int id_tarea = Convert.ToInt32(dgvTarea.Rows[idRowSeleccionadoEliminar].Cells["NUMERO"].Value.ToString());
                TareaControlador.eliminar(id_proyecto, id_tarea);
                reiniciarFormulario();
                listarTarea();
            }
        }

        private void dgvTarea_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }

        private void dgvTarea_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvTarea.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvTarea.Rows[idRowSeleccionado].Cells;
            cbProyecto.Text = celdas["PROYECTO"].Value.ToString();
            txtNumero.Text = celdas["NUMERO"].Value.ToString();
            txtHoraEstimada.Text = celdas["HORAESTIMADA"].Value.ToString();
            txtDescripcion.Text = celdas["descripcion"].Value.ToString();
            txtCostoEstimado.Text = celdas["COSTOESTIMADO"].Value.ToString();
            txtHoraReal.Text = celdas["HORAREAL"].Value.ToString();
            txtCostoReal.Text = celdas["COSTOREAL"].Value.ToString();
            txtHoraAvance.Text = celdas["horas_avance"].Value.ToString();


            btnGuardar.Text = "Guardar cambios";
        }
    }
}
