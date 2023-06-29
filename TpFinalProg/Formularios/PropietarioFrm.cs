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

namespace TpFinalProg
{
    public partial class PropietarioFrm : Form
    {
        public PropietarioFrm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Controlador.PropietarioControlador.listarTodo();
        }


        private void Propietario_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio del formulario Propietario.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string razonSocial = txtRazonSocial.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            Int64 cuit = Convert.ToInt64(txtCuit.Text);
            string contacto = txtContacto.Text;

            int idGenerado = Controlador.PropietarioControlador.crear(razonSocial, cuit, telefono, email, contacto);

            // Una vez insertado satisfactoriamente en la DB, se procede a añadir el propietario al DataGridView. Por último se limpian los campos.
            limpiarCampos();
        }

        private void limpiarCampos () {
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCuit.Text = "";
            txtContacto.Text = "";
        }
    }
}
