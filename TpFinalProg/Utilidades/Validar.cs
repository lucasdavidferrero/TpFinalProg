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


      /*  private static int calcularDigitoCuit(string cuit) {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++) {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }
      */
        public static bool cuit(string cuit) {
            if (cuit == null) {
                return false;
            }

            if (cuit.Length != 11) {
                return false;
            }else {
               // int calculado = calcularDigitoCuit(cuit);
                //int digito = int.Parse(cuit.Substring(10));
                //return calculado == digito;
                return true;
           }
        }
    }
}
