using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpFinalProg.Utilidades {
    /*
     *  Los métodos devolverán true si la validación es pasada correctamente (es válido).
     *  En caso de que sea inválido se retorna false.
     */
    internal class Validar {

        public static bool SoloNumeros(string input) {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        public static bool Email(string email) {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion)) {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}
