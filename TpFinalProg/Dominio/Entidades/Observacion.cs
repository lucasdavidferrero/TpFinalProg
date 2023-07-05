using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Dominio.Entidades {
    public class Observacion {
        public int idObservacion { get; }
        public DateTime fecha { get; }
        public string? observacion { get; }
        public int nroLegajo { get; }

        
        public Observacion() {

        }

        public Observacion(int idObservacion, DateTime fecha, string observacion) {
            this.idObservacion = idObservacion;
            this.fecha = fecha;
            this.observacion = observacion;
        }

        public Observacion(int idObservacion, DateTime fecha, string? observacion, int legajo) {
            this.idObservacion = idObservacion;
            this.fecha = fecha;
            this.observacion = observacion;
            nroLegajo = legajo;
        }
        public int guardar() {
            if (idObservacion == 0) {
                int id = ObservacionDataMapper.insertarNuevo(this);
                return id;
            }

            Observacion? obsEncontrado = ObservacionDataMapper.encontrarPorId(this.idObservacion);
            if (obsEncontrado != null) {
                ObservacionDataMapper.modificar(this);
                return idObservacion;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public DataTable? obtenerTodos() {
            return ObservacionDataMapper.obtenerTodos();
        }

        public void eliminarPorId(int id) {
            ObservacionDataMapper.eliminar(id);
        }
        public DataTable? obtenerTodosParametros() {
            return ObservacionDataMapper.obtenerTodosParametros();
        }
    }
}
