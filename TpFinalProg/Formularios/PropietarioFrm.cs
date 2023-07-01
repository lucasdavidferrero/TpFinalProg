﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Controlador;

namespace TpFinalProg {

    public partial class PropietarioFrm : Form {
        private int idRowSeleccionado = -1;
        public PropietarioFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Propietario_Load(object sender, EventArgs e) {
            listarPropietarios();
        }

        private void limpiarCampos() {
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCuit.Text = "";
            txtContacto.Text = "";
        }

        private void reiniciarFormulario() {
            limpiarCampos();
            this.idRowSeleccionado = -1;
            btnGuardar.Text = "Crear";
            txtCuit.Enabled = true;
        }

        private void listarPropietarios() {
            DataTable listadoPropietarios = Controlador.PropietarioControlador.listarTodo();
            dgvPropietario.DataSource = listadoPropietarios;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            string razonSocial = txtRazonSocial.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            Int64 cuit = Convert.ToInt64(txtCuit.Text);
            string contacto = txtContacto.Text;

            if (this.idRowSeleccionado < 0) {
                Controlador.PropietarioControlador.crear(razonSocial, cuit, telefono, email, contacto);
            } else {
                int idProp = Convert.ToInt32(dgvPropietario.Rows[this.idRowSeleccionado].Cells["id_propietario"].Value);
                PropietarioControlador.actualizar(idProp, razonSocial, cuit, telefono, email, contacto);
            }

            listarPropietarios();
            reiniciarFormulario();
        }

        private void dgvPropietario_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvPropietario.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvPropietario.Rows[idRowSeleccionado].Cells;
            txtRazonSocial.Text = celdas["razon_social"].Value.ToString();
            txtTelefono.Text = celdas["telefono"].Value.ToString();
            txtEmail.Text = celdas["email"].Value.ToString();
            txtCuit.Text = celdas["cuit"].Value.ToString();
            txtContacto.Text = celdas["persona_contacto"].Value.ToString();

            btnGuardar.Text = "Guardar cambios";
            txtCuit.Enabled = false;
            // TODO: No permitir que se modifique el CUIT. (invalidar el textbox)
        }

        private void btnModificar_Click(object sender, EventArgs e) {

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
