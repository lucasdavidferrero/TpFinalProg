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

       public static bool soloNumeros(string input) {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        public static bool email(string email) {
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

        // https://es.wikipedia.org/wiki/Clave_%C3%9Anica_de_Identificaci%C3%B3n_Tributaria
        public static bool cuit (string str) {
            Regex regex = new Regex("^\\b(20|23|24|27|30|33|34)\\d{8}\\d{1}$");
            return regex.IsMatch(str);
        }

         public static bool dinero (string str) {
            Regex regex = new Regex("/^\\d+(?:\\.\\d{0,2})?$");
            return regex.IsMatch(str);
        }
    }
}
