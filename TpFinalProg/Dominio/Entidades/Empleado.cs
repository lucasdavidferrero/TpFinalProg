using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Dominio.Entidades {
    internal class Empleado {
        public int legajo { get; }
        public DateTime fechaIngreso { get; }
        public string nombre { get; }
        public string apellido { get; }
        public string celular { get; }
        public string email { get; }
        public bool baja { get; }

        
        public Empleado() {

        }
        public Empleado(int legajo, DateTime fechaIngreso, string nombre, string apellido, string celular, string email) {
            this.legajo = legajo;
            this.fechaIngreso = fechaIngreso;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.email = email;
        }

        public Empleado(DateTime fechaIngreso, string nombre, string apellido, string celular, string email) {
            this.fechaIngreso = fechaIngreso;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.email = email;
        }

        public int guardar() {
            if (legajo == 0) {
                // TODO: Regla de negocio: Verificar que no exista un propietario con el CUIT que nos dan.
                int id = EmpleadoDataMapper.insertarNuevo(this);
                return id;
            }

            Empleado? empEncontrado = EmpleadoDataMapper.encontrarPorId(this.legajo);
            if (empEncontrado != null) {
                EmpleadoDataMapper.modificar(this);
                return legajo;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public DataTable? obtenerTodos() {
            return EmpleadoDataMapper.obtenerTodos();
        }
        public DataTable? obtenerTodosTodos() {
            return EmpleadoDataMapper.obtenerTodosTodos();
        }

        public void eliminarPorId(int id) {
            EmpleadoDataMapper.eliminar(id);
        }
        public static DataTable? CargarCombo() {
            DataSet? ds = EmpleadoDataMapper.cargarCombo();
            DataTable? dtListaAll = null;
            if (ds != null) {
                dtListaAll = ds.Tables[0];

            } else {
                Mensaje.Error("No hay datos para de categoria");
            }
            return dtListaAll;

        }
        public DataTable? buscarPorNombre(string nombre) {
            return EmpleadoDataMapper.buscarPorNombre(nombre);
        }
    }
}
