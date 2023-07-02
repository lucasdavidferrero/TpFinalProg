using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFinalProg.Utilidades {
    internal class Mensaje {
        public static void Correcto(string mensaje) {
            MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string mensaje) {
            MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Consulta(string mensaje) {
            if (MessageBox.Show(mensaje, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                return true;
            } else {
                return false;
            }
            // MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // MessageBox.Show ("Do you want to exit?", "My Application",  MessageBoxButtons.YesNo, MessageBoxIcon.Question)  
        }

        public static void Advertencia(string mensaje) {
            MessageBox.Show(mensaje, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
