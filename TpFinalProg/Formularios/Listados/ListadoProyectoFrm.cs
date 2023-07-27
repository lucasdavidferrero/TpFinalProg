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

namespace TpFinalProg.Formularios.Listados
{
    public partial class ListadoProyectoFrm : Form
    {
        public ListadoProyectoFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cargarDgvTerminados();
            cargarDgvNoTerminados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        private void cargarDgvTerminados()
        {
            dgvTerminados.DataSource = ProyectoControlador.obtenerProyectosConEmpresa(true);
        }

        private void cargarDgvNoTerminados()
        {
            dvgNoTerminados.DataSource = ProyectoControlador.obtenerProyectosConEmpresa(false);
        }

        private void dgvTerminados_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection celdas = dgvTerminados.Rows[e.RowIndex].Cells;
            int idProyectoSeleccionado = Convert.ToInt32(celdas["idProyectoTerminado"].Value.ToString());
            string? costoRealTotal = TareaDataMapper.obtenerCostoRealTotalPorProyecto(idProyectoSeleccionado);
            string? desvio = TareaDataMapper.obtenerDesvioPorProyecto(idProyectoSeleccionado);
            lblCostoRealTotal.Text = "$" + costoRealTotal;
            lblDesvio.Text = desvio;
        }

        private void dvgNoTerminados_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection celdas = dvgNoTerminados.Rows[e.RowIndex].Cells;
            int idProyectoSeleccionado = Convert.ToInt32(celdas["id_proyecto"].Value.ToString());
            decimal? porcentajeTareasCompletadas = TareaControlador.obtenerPorcentajeTareasCompletadas(idProyectoSeleccionado);
            lblAvance.Text = porcentajeTareasCompletadas.ToString() + "%";
        }
    }
}
