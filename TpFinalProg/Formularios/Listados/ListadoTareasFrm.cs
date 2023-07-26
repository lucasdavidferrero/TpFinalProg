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

namespace TpFinalProg.Formularios.Listados {
    public partial class ListadoTareasFrm : Form {

        bool primeraCargaCbProyectos = true;
        public ListadoTareasFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarComboProyectos();
            primeraCargaCbProyectos = false;
        }

        private void cargarComboProyectos() {
            DataTable? proyectos = ProyectoControlador.cargarCb();
            cbProyectos.DataSource = proyectos;
            cbProyectos.DisplayMember = "nombre";
            cbProyectos.ValueMember = "id_proyecto";
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

        }

        private void cbProyectos_TextChanged(object sender, EventArgs e) {
            if (primeraCargaCbProyectos) return;
            // cbProyectos.SelectedValue.ToString()
            /* Con el id del proyecto: buscar sus tareas finalizadas y no finalizadas y ponerlas en sus respectivos DataGridView */
            int idProyectoSeleccionado = (int)cbProyectos.SelectedValue;
            dgvTareasEnCurso.DataSource = TareaControlador.obtenerTareasEnCursoPorIdProyeto(idProyectoSeleccionado);
        }
    }
}
