using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Clases;
using TpFinalProg.Dominio;
using TpFinalProg.Dominio.Entidades;
using TpFinalProg.Dominio.Mappers;
using TpFinalProg.Utilidades;

namespace TpFinalProg.Controlador {
    internal class TrabajaControlador {
        public static void guardar(int idProyecto, int nroTarea, int legajo, int idFuncion) {
            if (!TrabajaControlador.verificarExistencia(idProyecto, nroTarea, legajo)){
                if (idFuncion != 1) {
                    Trabaja obj = new(legajo, idProyecto, nroTarea, idFuncion);

                    int id = TrabajaDataMapper.insertarNuevo(obj);

                    if (id == -1) {
                        MessageBox.Show("Ocurrió un error al asignar tarea", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } else if (ValidacionDatos.TareaAdmiteLider(idProyecto, nroTarea)) {
                    Trabaja obj = new(legajo, idProyecto, nroTarea, idFuncion);

                    int id = TrabajaDataMapper.insertarNuevo(obj);

                    if (id == -1) {
                        MessageBox.Show("Ocurrió un error al asignar tarea", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Para esta tarea ya hay un lider asignado, solo puede asignar un lider", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            else {
                MessageBox.Show("Ya existe una tarea asignada con estas caracteristicas", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void eliminar(int idTrabaja) {
            Trabaja obj = new(idTrabaja, 0, 0, 0, 0);

            if (!TrabajaDataMapper.eliminar(obj)) {
                MessageBox.Show("Ocurrió un error al eliminar asignación de tarea", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static bool verificarExistencia(int idProyecto, int nroTarea, int legajo) {
            DataTable registros = TrabajaDataMapper.buscarPorCaracteristicas(legajo, idProyecto, nroTarea);
            if (registros.Rows.Count > 0) {
                return true;
            }
            return false;

        }


        public static DataTable? cargarDgvTrabaja() {
            DataTable? dt = TrabajaDataMapper.cargarDgv();
            return dt;
        }

        

    }
}
