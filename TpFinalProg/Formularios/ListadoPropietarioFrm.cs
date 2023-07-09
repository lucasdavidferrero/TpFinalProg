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
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Formularios {
    public partial class ListadoPropietarioFrm : Form {
        public ListadoPropietarioFrm() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

            Int64 cuit = Convert.ToInt64(txtCuit.Text.Trim());

            DataTable prop = PropietarioDataMapper.encontrarPorCuitNoBaja(cuit);
            dgvPropietario.DataSource = prop;
                
        }
    }
}

