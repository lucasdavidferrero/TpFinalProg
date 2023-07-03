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

        /*  private void cargarCbPropietario() {

              // Obtén el DataTable desde tu fuente de datos
              DataTable dataTable = Controlador.PropietarioControlador.listarTodo();

              // Asigna el DataTable como origen de datos del ComboBox
              cbPropietario.DataSource = dataTable;

              // Especifica la columna que deseas mostrar en el ComboBox
              cbPropietario.DisplayMember = "razon_social";

              // Opcionalmente, especifica la columna que deseas utilizar como valor seleccionado
              cbPropietario.ValueMember = "id_propietario";
          }
          private void cargarCbResponsable() {

              // Obtén el DataTable desde tu fuente de datos
              DataTable dataTable = Controlador.EmpleadoControlador.listarTodo();

              // Asigna el DataTable como origen de datos del ComboBox
              cbResponsable.DataSource = dataTable;

              // Especifica la columna que deseas mostrar en el ComboBox
              cbResponsable.DisplayMember = "nombre";

              // Opcionalmente, especifica la columna que deseas utilizar como valor seleccionado
              cbResponsable.ValueMember = "legajo";
          }
        */

        /*   private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e) {
               // Agrega una fila vacía al DataGridView si no tiene filas
               if (dgvProyecto.Rows.Count == 0) {
                   dgvProyecto.Rows.Add();
               }
               // Obtén el elemento seleccionado del ComboBox
               DataRowView selectedRow = cbPropietario.SelectedItem as DataRowView;

               if (selectedRow != null) {
                   // Obtén el valor del elemento seleccionado
                   int selectedId = Convert.ToInt32(selectedRow["id_propietario"]);

                   // Filtra los datos del DataTable original para obtener un nuevo DataTable con los datos seleccionados
                   Propietario pSeleccionado = PropietarioDataMapper.obtenerPorId(selectedId);

                  /* // Recorre las filas del DataGridView
                   foreach (DataGridViewRow row in dgvProyecto.Rows) {
                       // Asigna el valor del propietario a la columna correspondiente
                       row.Cells["PROPIETARIO"].Value = pSeleccionado.razonSocial;*/


        //  }
        //   }
        private bool validarFrm() {
            string mensajeError = "";
            bool hayAlMenosUnError = false;
            if (string.IsNullOrEmpty(txtNombre.Text)) {
                mensajeError += "- El Nombre es obligatorio. \n";
                hayAlMenosUnError = true;
            }

            if (string.IsNullOrEmpty(txtMonto.Text)) {
                mensajeError += "- El Monto esta vacío o es inválido. \n";
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


            if (ValidacionDatos.PropietarioAdmiteProyecto(idPropietario)) {
                try {
                    if (this.idRowSeleccionado < 0) {
                        Controlador.ProyectoControlador.crear(nombre, montoEstimado, tiempoEstimado, idPropietario, legajo);
                    } else {
                        int idProy = Convert.ToInt32(dgvProyecto.Rows[this.idRowSeleccionado].Cells["id_proyecto"].Value);
                        ProyectoControlador.actualizar(idProy, nombre, montoEstimado, tiempoEstimado, idPropietario, legajo);
                    }

                    listarProyecto();
                    reiniciarFormulario();

                } catch (Exception ex) {
                    Mensaje.Advertencia(ex.Message);
                }
            } else {
                Mensaje.Error("El propietario tiene mas de 3 proyectos cargados");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (idRowSeleccionadoEliminar >= 0) {
                int id_proyecto = Convert.ToInt32(dgvProyecto.Rows[idRowSeleccionadoEliminar].Cells["id_proyecto"].Value.ToString());
                ProyectoControlador.eliminar(id_proyecto);
                reiniciarFormulario();
                listarProyecto();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            reiniciarFormulario();
        }

        private void dgvProyecto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = false;
            // El último row siempre esta vacío. No hacemos nada en ese caso.
            if (dgvProyecto.Rows.Count - 1 == e.RowIndex)
                return;

            idRowSeleccionado = e.RowIndex;

            // Llenar los Textboxs con los correspondientes datos del Row seleccionado.
            DataGridViewCellCollection celdas = dgvProyecto.Rows[idRowSeleccionado].Cells;
            txtNombre.Text = celdas["nombre"].Value.ToString();
            txtMonto.Text = celdas["MONTO_ESTIMADO"].Value.ToString();
            txtTiempo.Text = celdas["tiempo_estimado"].Value.ToString();

            cbPropietario.Text = celdas["razon_social"].Value.ToString();
            cbResponsable.Text = celdas["RESPONSABLE"].Value.ToString();

            /*  int idPropietario = Convert.ToInt32(celdas["id_propietario"].Value);
               cbPropietario.SelectedValue = idPropietario;

               PropietarioDataMapper.encontrarPorIdRazonSocial(idPropietario);

               cbPropietario.SelectedValue = idPropietario;

               int idResponsable = Convert.ToInt32(celdas["legajo"].Value);
               cbResponsable.SelectedValue = idResponsable;

               EmpleadoDataMapper.encontrarPorIdNombre(idResponsable);

               cbResponsable.SelectedValue = idResponsable;*/


            btnGuardar.Text = "Guardar cambios";
        }

        private void dgvProyecto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            btnEliminar.Enabled = true;
            this.idRowSeleccionadoEliminar = e.RowIndex;
        }



        /* foreach (DataRow row in listadoProyecto.Rows) {
             // Accede a los valores de cada columna en la fila actual
             foreach (DataColumn column in listadoProyecto.Columns) {
                 // Accede al valor de la columna en la fila actual
                 object value = row["id_propietario"];

                 // Haz algo con el valor, como mostrarlo en la consola
                 Console.WriteLine(value.ToString());
             }
         }


         // Obtén el elemento seleccionado del ComboBox
         DataRowView selectedRow = cbPropietario.SelectedItem as DataRowView;

         if (selectedRow != null) {
             // Obtén el valor del elemento seleccionado
             int selectedId = Convert.ToInt32(selectedRow["id_propietario"]);

             // Filtra los datos del DataTable original para obtener un nuevo DataTable con los datos seleccionados
             Propietario pSeleccionado = PropietarioDataMapper.obtenerPorId(selectedId);

             foreach (DataGridViewRow row in dgvProyecto.Rows) {
                 // Asigna el valor del propietario a la columna correspondiente
                 row.Cells["PROPIETARIO"].Value = pSeleccionado.razonSocial;
             }
         }*/
    }



}

