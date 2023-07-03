﻿using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Mappers;

namespace TpFinalProg.Dominio.Entidades {
    internal class Proyecto {
        public int idProyecto { get; }

        public string nombre { get; set; }

        public double montoEstimado { get; }

        public int tiempoEstimado { get; }
        public int idPropietario { get; }
        public int nroLegajo { get; }

        public Proyecto(int idProyecto, string nombre, double montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
            this.idProyecto = idProyecto;
            this.nombre = nombre;
            this.montoEstimado = montoEstimado;
            this.tiempoEstimado = tiempoEstimado;
            this.idPropietario = idPropietario;
            this.nroLegajo = legajo;
        }

         public Proyecto() { }
        public int guardar() {
            if (idProyecto == 0) {
                int id = ProyectoDataMapper.insertarNuevo(this);
                return id;
            }

            Proyecto proEncontrado = ProyectoDataMapper.encontrarPorId(this.idPropietario);
            if (proEncontrado != null) {
                ProyectoDataMapper.modificar(this);
                return idProyecto;
            } else {
                return -1; // no se encontró un propietario con el ID provisto.
            }
        }

        public DataTable obtenerTodos() {
            return ProyectoDataMapper.obtenerTodos();
        }
        public DataTable obtenerTodosParametros() {
            return ProyectoDataMapper.obtenerTodosParametros();
        }

        public void eliminarPorId(int id) {
            ProyectoDataMapper.eliminar(id);
        }

    }
}
