using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ESTO ES AGG PARA QUE SIRVA LO DEMAS
using System.Data.SqlClient;
using System.Data;


namespace TpFinalProg.Clases
{
    internal class Conexion
    {

        //SI ME TOMA EN ROJITO LO DE ABAJO VOY A DEPENDENCIAS Y A AGREGAR NUGETS Y PONGO SQLCLIENT
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private string stringCox = "Data Source=EMI\\LOCALHOST;Initial Catalog=TPProg;Integrated Security=True";

        public void AbrirConexion()
        {
            try
            {
                conexion.ConnectionString = stringCox;
                conexion.Open();
                MessageBox.Show("Se conecto");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se conecto" + e.ToString());
            }
        }
        public void CerrarConexion()
        {
            try
            {
                this.conexion.Close();
                MessageBox.Show("Se cero");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se cerro" + e.ToString());
            }
        }
        public DataSet cargarCombo()
        {
            DataSet ds = new DataSet("Funcion");
            string sql = "SELECT id_funcion, descripcion FROM Funcion order by descripcion";

            try
            {
                cmd = new SqlCommand(sql);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = this.conexion; //la q tengo abierta no el conexion de la propiedad 

                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd); //trae todo
                sqlDat.Fill(ds); //me llena el data set
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cerro" + ex.ToString());
            }
            return ds;
        }
    }
}
