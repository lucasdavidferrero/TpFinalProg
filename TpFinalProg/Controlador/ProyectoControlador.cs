using PruebaTpFinal.Dominio.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFinalProg.Dominio.Entidades;

namespace TpFinalProg.Controlador {
    internal class ProyectoControlador {

         public static int crear(string nombre, double montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
             Proyecto clsProyecto = new Proyecto(0, nombre, montoEstimado , tiempoEstimado, idPropietario, legajo);
             int idGenerado = clsProyecto.guardar();
             return idGenerado;
         }

        public static void actualizar(int id_proyecto, string nombre, double montoEstimado, int tiempoEstimado, int idPropietario, int legajo) {
             Proyecto p = new Proyecto(id_proyecto, nombre, montoEstimado, tiempoEstimado,  idPropietario, legajo);
             p.guardar();
         }

         public static void eliminar(int id) {
            Proyecto clsProyecto = new Proyecto();
            clsProyecto.eliminarPorId(id);
         }

         public static DataTable listarTodo() {
            Proyecto clsProyecto = new Proyecto();
             DataTable proyectos = clsProyecto.obtenerTodos();
             return proyectos;
         }

        public static DataTable listarPorId(int id) {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_proyecto", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("monto_estimado", typeof(float));
            dt.Columns.Add("tiempo_estimado", typeof(int));
            dt.Columns.Add("id_propietario", typeof(int));
            dt.Columns.Add("legajo", typeof(int));

            Proyecto proyecto = ProyectoDataMapper.encontrarPorId(id);
            DataRow row = dt.NewRow();
            row["id_proyecto"] = proyecto.idProyecto;
            row["nombre"] = proyecto.nombre;
            row["monto_estimado"] = proyecto.montoEstimado;
            row["tiempo_estimado"] = proyecto.tiempoEstimado;
            row["id_propietario"] = proyecto.idPropietario;
            row["legajo"] = proyecto.nroLegajo;

            dt.Rows.Add(row);
            return dt;
        }

     }

   

}

