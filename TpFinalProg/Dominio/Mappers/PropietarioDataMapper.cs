using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio.Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TpFinalProg.Dominio.Mappers {
    internal class PropietarioDataMapper {

        public static int insertarNuevo (Propietario p) {
            // Construcción del query parametrizado.
            string q = "INSERT INTO Propietario(razon_social,telefono,email,cuit,persona_contacto) VALUES(@razonSocial,@telefono,@email,@cuit,@personaContacto); SELECT SCOPE_IDENTITY();";
            int idGenerado = -1;
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@razonSocial", SqlDbType.NVarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@cuit", SqlDbType.BigInt);
            cmd.Parameters.Add("@personaContacto", SqlDbType.NVarChar);

            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@razonSocial"].Value = p.razonSocial;
            cmd.Parameters["@telefono"].Value = p.telefono;
            cmd.Parameters["@email"].Value = p.email;
            cmd.Parameters["@cuit"].Value = p.cuit;
            cmd.Parameters["@personaContacto"].Value = p.personaContacto;

            // Ejecución del SQL
            try {
                cx.SetComandoSQL(q);
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                return idGenerado;
            } catch(SqlException) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return idGenerado;
        }
        public static DataTable? obtenerTodos() {
            DataTable? dtListAll = new DataTable("ListarPropietarios");
            string q = "SELECT * FROM Propietario WHERE baja = 0";
            Conexion cx = new Conexion();
            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);

            } catch (SqlException) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Propietarios]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        public static int modificar (Propietario p) {
            // Construcción del query parametrizado.
            string q = "UPDATE Propietario SET razon_social = @razonSocial , telefono = @telefono, email = @email, persona_contacto = @personaContacto WHERE id_propietario = @Id AND baja = 0";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            // Asignación de tipos de datos correspondientes a la base de datos.
            cmd.Parameters.Add("@razonSocial", SqlDbType.NVarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@personaContacto", SqlDbType.NVarChar);

            // Asignación de valores a cada parámetro SQL.
            cmd.Parameters["@razonSocial"].Value = p.razonSocial;
            cmd.Parameters["@telefono"].Value = p.telefono;
            cmd.Parameters["@email"].Value = p.email;
            cmd.Parameters["@personaContacto"].Value = p.personaContacto;

            cmd.Parameters.AddWithValue("@Id", p.idPropietario);

            // Ejecución del SQL
            try {
                cx.SetComandoSQL(q);
                cmd.ExecuteScalar();
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Insertar Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return p.idPropietario;
        }

        public static Propietario? obtenerPorId (int id) {
            Propietario? propEncontrado = null;
            string q = "SELECT * FROM Propietario WHERE id_propietario = @Id AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                if (dt.Rows.Count != 0) {
                    propEncontrado = construirPropietarioDesdeDataRow(dt.Rows[0]);
                }
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return propEncontrado;
        }

        public static Propietario? obtenerPorCuit (long cuit) {
            Propietario? propEncontrado = null;
            string q = "SELECT * FROM Propietario WHERE cuit = @cuit AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@cuit", cuit);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                if (dt.Rows.Count != 0) {
                    propEncontrado = construirPropietarioDesdeDataRow(dt.Rows[0]);
                }
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Obtener por Cuit Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return propEncontrado;
        }

        public static void eliminar (int id) {
            string q = "UPDATE Propietario SET baja = @baja WHERE id_propietario = @Id";
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.Add("@baja", SqlDbType.Bit);
            cmd.Parameters["@baja"].Value = 1;

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                cmd.ExecuteScalar();
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Obtener por Id Propietario]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
        }

        public static DataTable? buscarPorRazonSocial (string razonSocial) {
            DataTable? dtListAll = new DataTable("ListarPropietarios");
            string q = $"SELECT * FROM Propietario WHERE razon_social LIKE '%{razonSocial}%' AND baja = 0;";
            Conexion cx = new Conexion();
            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dtListAll);

            } catch (SqlException) {
                dtListAll = null;
                Console.WriteLine("Error en la base de datos. [Listado Propietarios]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return dtListAll;
        }

        private static Propietario construirPropietarioDesdeDataRow (DataRow dr) {
            int pId = Convert.ToInt32(dr["id_propietario"]);
            string pRazonSocial = dr["razon_social"].ToString()!;
            Int64 pCuit = Convert.ToInt64(dr["cuit"]);
            string pTel = dr["telefono"].ToString()!;
            string pEmail = dr["email"].ToString()!;
            string pPersonaContacto = dr["persona_contacto"].ToString()!;
            return new Propietario(pId, pRazonSocial, pCuit, pTel, pEmail, pPersonaContacto);
        }

        public static DataSet? cargarCombo() {
            DataSet dt = new DataSet();
            string sql = "Select 0 as id_propietario, 'Seleccione...' as descripcion " +
                "Union SELECT id_propietario, razon_social FROM Propietario WHERE baja=0 order by id_propietario ";

            try {
                Conexion cx = new Conexion();
                SqlCommand cmd = cx.getComando();
                cx.SetComandoSQL(sql);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
                cx.cerrarConexionLiberarRecursos();

            } catch (SqlException) {
                return null;
            }
            return dt;
        }

        public static Propietario? encontrarPorIdRazonSocial(int id) {
            Propietario? propEncontrado = null;
            string q = "SELECT razon_social FROM Propietario WHERE id_propietario = @Id AND baja = 0";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            cmd.Parameters.AddWithValue("@Id", id);

            try {
                cx.SetComandoSQL(q);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                cmd.ExecuteScalar();
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Obtener por Razon Social]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }

            return propEncontrado;
        }
        public static DataTable buscarPorCuit(long cuit, int baja = 0) {
            string query = $"SELECT * FROM Propietario WHERE cuit LIKE '{cuit}%' AND baja={baja}";
            DataTable dt = new DataTable();
            Conexion cx = new Conexion();
            SqlCommand cmd = cx.getComando();

            try {
                cx.SetComandoSQL(query);
                SqlDataAdapter sqlDat = new SqlDataAdapter(cx.getComando());
                sqlDat.Fill(dt);
            } catch (SqlException) {
                Console.WriteLine("Error en la base de datos. [Obtener por CUIT]");
            } finally {
                cx.cerrarConexionLiberarRecursos();
            }
            return dt;
        }


    }
}
