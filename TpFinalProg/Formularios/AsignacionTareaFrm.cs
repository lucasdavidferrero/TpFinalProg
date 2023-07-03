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
        public AsignacionTareaFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarCbProyecto();
            cargarCbEmpleado();
            cargarCbFuncion();
            cargarDgvTarea();
        }

        private void butGuardar_Click(object sender, EventArgs e) {

        }

        private void cargarCbProyecto() {

            DataTable proyectos = ProyectoDataMapper.obtenerTodos();
            cbProyecto.DataSource = proyectos;
            cbProyecto.DisplayMember = "nombre";
            cbProyecto.ValueMember = "id_proyecto";
        }

        private void cargarCbTarea(int idProyecto) {
            DataTable tareas = TareaDataMapper.encontrarPorIdProyecto(idProyecto);
            cbTarea.DataSource = tareas;
            cbTarea.DisplayMember = "nombre";
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
            // Obtén el elemento seleccionado del ComboBox
            DataRowView selectedRow = cbProyecto.SelectedItem as DataRowView;

            if (selectedRow != null) {
                // Obtén el valor del elemento seleccionado
                int selectedId = Convert.ToInt32(selectedRow["id_proyecto"]);

                cargarCbTarea(selectedId);
            }
        }

        private void cargarDgvTarea() {
            DataTable tareas = TareaDataMapper.obtenerTodos();
            DataTable trabaja = TrabajaDataMapper.obtenerTodos();
            tareas.Columns.Add("empleado");
            tareas.Columns.Add("funcion");

            foreach (DataRow row in tareas.Rows) {
                foreach (DataRow row2 in trabaja.Rows) {
                    if (row["id_proyecto"] == row2["id_proyecto"] && row["nro_tarea"] == row2["id_tarea"]) {
                        row["empleado"] = row2["legajo"];
                        row["funcion"] = row2["id_funcion_fk"];
                    }
                }

            }

            dgvTarea.DataSource = trabaja;

        }


        private void guardarTarea() {
            int id_proyecto = Convert.ToInt32(cbProyecto.SelectedIndex);
            int nro_tarea = Convert.ToInt32(cbTarea.SelectedIndex);
            int legajo = Convert.ToInt32(cbEmpleado.SelectedIndex);
            int id_funcion = Convert.ToInt32(cbFuncion.SelectedIndex);

            TrabajaControlador.guardar(id_proyecto, nro_tarea, legajo, id_funcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            guardarTarea();
        }

        
        
        private void btnBorrar_Click(object sender, EventArgs e) {
            int id_proyecto = Convert.ToInt32(cbProyecto.SelectedIndex);
            int nro_tarea = Convert.ToInt32(cbTarea.SelectedIndex);
            int legajo = Convert.ToInt32(cbEmpleado.SelectedIndex);

            TrabajaControlador.eliminar(id_proyecto, nro_tarea, legajo);

        }
    }
}
