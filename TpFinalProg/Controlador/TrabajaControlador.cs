using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Controlador {
    internal class TrabajaControlador {
        public static void guardar(int idProyecto, int nroTarea, int legajo, int idFuncion) {
            
            if (ValidacionDatos.TareaAdmiteLider(idProyecto, nroTarea)) {
                Trabaja obj = new(legajo, idProyecto, nroTarea, idFuncion);

                Tuple<int, int, int> respuesta = TrabajaDataMapper.insertarNuevo(obj);

                if (respuesta == null) {
                    MessageBox.Show("Ocurrió un error al asignar tarea");
                }
            } else {
                MessageBox.Show("Para esta tarea ya hay un lider asignado, solo puede asignar un lider");
            }

        }


        public static void eliminar(int idProyecto, int nroTarea, int legajo) {
            Trabaja obj = new(legajo, idProyecto, nroTarea, 0);

            if (!TrabajaDataMapper.eliminar(obj)) {
                MessageBox.Show("Ocurrió un error al eliminar asignación de tarea");
            }
        }
    }
}
