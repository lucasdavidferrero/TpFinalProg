using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpFinalProg.Controlador;
using TpFinalProg.Utilidades;

namespace TpFinalProg {

    public partial class PropietarioFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;
        public PropietarioFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Propietario_Load(object sender, EventArgs e) {
            listarPropietarios();
            btnEliminar.Enabled = false;
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
            this.idRowSeleccionadoEliminar = -1;
            btnGuardar.Text = "Crear";
            txtCuit.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void listarPropietarios() {
            DataTable listadoPropietarios = Controlador.PropietarioControlador.listarTodo();
            dgvPropietario.DataSource = listadoPropietarios;
        }

        // Si existe error, retorna true.
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;
            if (string.IsNullOrEmpty(txtRazonSocial.Text)) {
                mensajeError += "- La Razón Social es obligatoria. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtCuit.Text) || !Validar.soloNumeros(txtCuit.Text) || !Validar.cuit(txtCuit.Text)) {
                mensajeError += "- El CUIT esta vacío o es inválido. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text) || !Validar.soloNumeros(txtTelefono.Text)) {
                mensajeError += "- El Teléfono esta vacío o es inválido. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || !Validar.email(txtEmail.Text)) {
                mensajeError += "- El email esta vacío o tiene un formato inválido. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtContacto.Text)) {
                mensajeError += "- La Persona de Contacto es obligatoria. \n";
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
            string razonSocial = txtRazonSocial.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            Int64 cuit = Convert.ToInt64(txtCuit.Text.Trim());
            string contacto = txtContacto.Text.Trim();

            try {
                if (this.idRowSeleccionado < 0) {
                    Controlador.PropietarioControlador.crear(razonSocial, cuit, telefono, email, contacto);
                } else {
                    int idProp = Convert.ToInt32(dgvPropietario.Rows[this.idRowSeleccionado].Cells["id_propietario"].Value);
                    PropietarioControlador.actualizar(idProp, razonSocial, cuit, telefono, email, contacto);
                }

                listarPropietarios();
                reiniciarFormulario();
            } catch (Exception ex) {
                Mensaje.Advertencia(ex.Message);
            }
        }

        private void dgvPropietario_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
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
        }

        private void dgvPropietario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                int idPropietario = Convert.ToInt32(dgvPropietario.Rows[idRowSeleccionadoEliminar].Cells["id_propietario"].Value.ToString());
                PropietarioControlador.eliminar(idPropietario);
                reiniciarFormulario();
                listarPropietarios();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

    }
}
