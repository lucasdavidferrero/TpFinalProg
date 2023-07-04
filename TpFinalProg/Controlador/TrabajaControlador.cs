using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

                    Tuple<int, int, int> respuesta = TrabajaDataMapper.insertarNuevo(obj);

                    if (respuesta == null) {
                        MessageBox.Show("Ocurrió un error al asignar tarea");
                    }

                } else if (ValidacionDatos.TareaAdmiteLider(idProyecto, nroTarea)) {
                    Trabaja obj = new(legajo, idProyecto, nroTarea, idFuncion);

                    Tuple<int, int, int> respuesta = TrabajaDataMapper.insertarNuevo(obj);

                    if (respuesta == null) {
                        MessageBox.Show("Ocurrió un error al asignar tarea");
                    }
                } else {
                    MessageBox.Show("Para esta tarea ya hay un lider asignado, solo puede asignar un lider");
                }
            
            }
            else {
                MessageBox.Show("Ya existe una tarea asignada con estas caracteristicas");
            }
        }


        public static void eliminar(int idProyecto, int nroTarea, int legajo) {
            Trabaja obj = new(legajo, idProyecto, nroTarea, 0);

            if (!TrabajaDataMapper.eliminar(obj)) {
                MessageBox.Show("Ocurrió un error al eliminar asignación de tarea");
            }
        }


        public static bool verificarExistencia(int idProyecto, int nroTarea, int legajo) {
            if (TrabajaDataMapper.encontrarPorId(legajo, idProyecto, nroTarea) != null) {
                return true;
            }
            return false;

        }


        public static DataTable cargarDgvTrabaja() {
            DataTable tareas = TareaDataMapper.obtenerTodos();
            DataTable trabaja = TrabajaDataMapper.obtenerTodos();
            DataTable empleados = EmpleadoDataMapper.obtenerTodos();
            DataTable funciones = FuncionDataMapper.obtenerTodos();
            DataTable proyectos = ProyectoDataMapper.obtenerTodos();

            // Agregar columnas al DataTable "trabaja" para los nombres
            trabaja.Columns.Add("empleado", typeof(string));
            trabaja.Columns.Add("funcion", typeof(string));
            trabaja.Columns.Add("proyecto", typeof(string));

            // Combinar los datos de los DataTables en uno solo
            foreach (DataRow row in trabaja.Rows) {
                int legajo = Convert.ToInt32(row["legajo"]);
                int idFuncion = Convert.ToInt32(row["id_funcion_fk"]);
                int idProyecto = Convert.ToInt32(row["id_proyecto"]);

                // Obtener el nombre del empleado
                DataRow empleadoRow = empleados.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["legajo"]) == legajo);
                if (empleadoRow != null) {
                    string nombreEmpleado = empleadoRow["nombreCompleto"].ToString();
                    row["empleado"] = nombreEmpleado;
                }

                // Obtener el nombre de la función
                DataRow funcionRow = funciones.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["id_funcion"]) == idFuncion);
                if (funcionRow != null) {
                    string nombreFuncion = funcionRow["descripcion"].ToString();
                    row["funcion"] = nombreFuncion;
                }

                // Obtener el nombre del proyecto
                DataRow proyectoRow = proyectos.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["id_proyecto"]) == idProyecto);
                if (proyectoRow != null) {
                    string nombreProyecto = proyectoRow["nombre"].ToString();
                    row["proyecto"] = nombreProyecto;
                }

                
            }

            
            return trabaja;
        }

        public static bool modificar(int idProyecto, int nroTarea, int legajo, int idFuncion) {
            if (TrabajaControlador.verificarExistencia(idProyecto, nroTarea, legajo)) {

                if(idFuncion == 1) {
                    if (!ValidacionDatos.TareaAdmiteLider(idProyecto, nroTarea)) {
                        MessageBox.Show("No se puede asignar mas de un lider");
                        return false;
                    }
                } else {
                    Trabaja obj = new(legajo, idProyecto, nroTarea, idFuncion);
                    TrabajaDataMapper.modificar(obj);

                    MessageBox.Show("Asignacion modificada");
                    return true;
                }
                

            } else {
                MessageBox.Show("No se puede modificar una asignacion inexistente");
            }
            return false;
        }

    }
}
