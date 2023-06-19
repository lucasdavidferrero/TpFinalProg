using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Transactions;

namespace TpFinalProg.Clases {
    internal class Conexion {
        SqlConnection conexion = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlTransaction transaccion;

        private string strConx = ConfigurationManager.ConnectionStrings["Proyectos"].ConnectionString;
        public Conexion() { }

        private void abrirConexion() {
            try {
                conexion.ConnectionString = strConx;
                conexion.Open();
            } catch (SqlException e) {
                MessageBox.Show("No hay conexión: " + e.ToString());
            }

        }

        private void cerrarConexion() {
            try {
                this.conexion.Close();
                this.conexion.Dispose();
            } catch (SqlException e) {
                MessageBox.Show("No hay conexión: " + e.ToString());
            }

        }

        public void SetComandoSQL(string queryString) {
            this.cmd.CommandText = queryString;
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.abrirConexion();
            this.cmd.Connection = this.conexion;
        }

        public SqlCommand getComando() {
            return this.cmd;
        }


        private void IniciarTransaccion() {
            transaccion = conexion.BeginTransaction();
            cmd.Transaction = transaccion;
        }

        private void CommitTransaccion() {
            transaccion.Commit();
        }

        private void RollbackTransaccion() {
            transaccion.Rollback();
        }

        public void cerrarConexionLiberarRecursos() {
            this.cmd.Dispose();
            this.cerrarConexion();
        }
    }
}
