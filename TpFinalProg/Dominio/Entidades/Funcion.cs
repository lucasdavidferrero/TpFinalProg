using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Dominio.Entidades {
    public class Funcion {
        public int idFuncion { get; }
        public string descripcion { get; }

        public Funcion () { }

        public Funcion(int idFuncion, string descripcion) {
            this.idFuncion = idFuncion;
            this.descripcion = descripcion;
        }

        /* 
         * La creación de las funcioens se hace por única vez en el inicio del programa (La primera vez que se inicia.)
         */
        public void crearFunciones () {
            DataTable dt = this.listarFunciones();
            if (dt.Rows.Count > 0) {
                return;
            }
            // Crear las funciones.
            Funcion[] funciones = {
                new Funcion(0, "Lider"),
                new Funcion(0, "Señor"),
                new Funcion(0, "Semi-señor"),
                new Funcion(0, "Junior")
            };
            FuncionDataMapper.crearFunciones(funciones);
        }

        public DataTable listarFunciones () {
            DataTable dt = FuncionDataMapper.obtenerTodos();
            return dt;
        }
    }
}
