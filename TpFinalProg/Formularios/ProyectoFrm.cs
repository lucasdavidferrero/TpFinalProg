using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Controlador;
using TpFinalProg.Utilidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Dominio;

namespace TpFinalProg {
    public partial class ProyectoFrm : Form {
        private int idRowSeleccionado = -1;
        private int idRowSeleccionadoEliminar = -1;

        public ProyectoFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            cargarCbResponsable();
            cargarCbPropietario();
            listarProyecto();
            btnEliminar.Enabled = false;
        }

        private void cargarCbResponsable() {
            DataTable ta = Empleado.CargarCombo();
            cbResponsable.DataSource = ta.DefaultView;
            cbResponsable.ValueMember = "legajo";
            cbResponsable.DisplayMember = "descripcion";
        }
        private void cargarCbPropietario() {
            DataTable ta = Propietario.CargarCombo();
            cbPropietario.DataSource = ta.DefaultView;
            cbPropietario.ValueMember = "id_propietario";
            cbPropietario.DisplayMember = "descripcion";
        }
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;
            if (string.IsNullOrEmpty(txtNombre.Text)) {
                mensajeError += "- El Nombre es obligatorio. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtMonto.Text) || !Validar.dinero(txtMonto.Text)) {
                mensajeError += "- El Monto esta vacío o posee un formato inválido. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtTiempo.Text) || !Validar.soloNumeros(txtTiempo.Text)) {
                mensajeError += "- El Tiempo esta vacío o es inválido. \n";
                hayAlMenosUnError = true;
            }
            if (cbResponsable.SelectedIndex == 0) {
                mensajeError += "- Seleccione un Responsable. \n";
                hayAlMenosUnError = true;
            }
            if (cbPropietario.SelectedIndex == 0) {
                mensajeError += "- Seleccione un Propietario. \n";
                hayAlMenosUnError = true;
            }
            if (hayAlMenosUnError) {
                Mensaje.Error(mensajeError);
            }
            return hayAlMenosUnError;
        }
        private void limpiarCampos() {
            txtNombre.Text = "";
            txtMonto.Text = "";
            txtTiempo.Text = "";
            txtid.Text = "";
            cargarCbResponsable();
            cargarCbPropietario();
        }
        private void reiniciarFormulario() {
            limpiarCampos();
            this.idRowSeleccionado = -1;
            this.idRowSeleccionadoEliminar = -1;
            btnGuardar.Text = "Crear";
            btnEliminar.Enabled = false;
        }
        private void listarProyecto() {
            DataTable listadoProyecto = Controlador.ProyectoControlador.listarTodoParametro();
            dgvProyecto.DataSource = listadoProyecto;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (validarFrm()) {
                return;
            }


            string nombre = txtNombre.Text.Trim();
            decimal montoEstimado = Convert.ToDecimal(txtMonto.Text.Trim());
            int tiempoEstimado = Convert.ToInt32(txtTiempo.Text.Trim());
            int idPropietario = Convert.ToInt32(cbPropietario.SelectedValue);
            int legajo = Convert.ToInt32(cbResponsable.SelectedValue);


            if (ValidacionDatos.responsableCantidadProyectosActivos(legajo)) {
                try {

                    if (this.idRowSeleccionado < 0) {
                        Controlador.ProyectoControlador.crear(nombre, montoEstimado, tiempoEstimado, idPropietario, legajo);
                        Mensaje.Correcto("Guardado Exitosamente");
                    } else {
                        int idProy = Convert.ToInt32(dgvProyecto.Rows[this.idRowSeleccionado].Cells["id_proyect"].Value);
                        ProyectoControlador.actualizar(idProy, nombre, montoEstimado, tiempoEstimado, idPropietario, legajo);
                        Mensaje.Correcto("Modificado Exitosamente");
                    }

                    listarProyecto();
                    reiniciarFormulario();

                } catch (Exception ex) {
                    Mensaje.Advertencia(ex.Message);
                }
            } else {
                Mensaje.Error("El responsable tiene más de 3 proyectos a cargo en este momento.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                if (Mensaje.Consulta("Estas seguro que quiere eliminar?")) {
                    int id_proyecto = Convert.ToInt32(dgvProyecto.Rows[idRowSeleccionadoEliminar].Cells["id_proyect"].Value.ToString());
                    ProyectoControlador.eliminar(id_proyecto);
                    Mensaje.Correcto("Eliminado Exitosamente");
                    reiniciarFormulario();
                    listarProyecto();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
            listarProyecto();
        }

        private void dgvProyecto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            if (dgvProyecto.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvProyecto.Rows[idRowSeleccionado].Cells;
            txtid.Text = celdas["id_proyect"].Value.ToString();
            txtNombre.Text = celdas["nombre"].Value.ToString();
            txtMonto.Text = celdas["MONTO_ESTIMADO"].Value.ToString();
            txtTiempo.Text = celdas["tiempo_estimado"].Value.ToString();

            cbPropietario.Text = celdas["razon_social"].Value.ToString();
            cbResponsable.Text = celdas["RESPONSABLE"].Value.ToString();

            btnGuardar.Text = "Guardar cambios";
        }

        private void dgvProyecto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }
    }



}

