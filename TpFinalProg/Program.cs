using TpFinalProg.Controlador;

namespace TpFinalProg
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuFrm());

        }
    }
}

/* 
    La capa de Formularios se comunica con Controlador.
    La capa de Controlador se comunica con Las Entidades.
    La capa Entidades se comunica con la capa de Datos a través de DataMappers.

    Las clases "DataMappers" tienen la responsabilidad de construir el Query SQL según cada situación. Además, son las clases
    que se comunican con la base de datos a través de la capa de Datos.
    De esta manera, podemos hacer consultas en cualquier tabla SQL desde cualquier Entidad.
 */