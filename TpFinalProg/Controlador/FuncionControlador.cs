using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class FuncionControlador {

        public static void crearFuncionesSinoExisten () {
            Funcion clsFuncion = new Funcion();
            clsFuncion.crearFunciones();
        }


        public static DataTable? cargarCb() {
            DataTable? dt = FuncionDataMapper.cargarCb();
            return dt;
        }
    }
}
