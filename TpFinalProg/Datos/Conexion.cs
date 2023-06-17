﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TpFinalProg.Clases {
    internal class Conexion {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

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

        public void cerrarConexionLiberarRecursos() {
            this.cmd.Dispose();
            this.cerrarConexion();
        }
    }
}
