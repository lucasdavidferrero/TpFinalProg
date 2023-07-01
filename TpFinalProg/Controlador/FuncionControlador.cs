using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpFinalProg.Controlador {
    internal class FuncionControlador {
        private static int CalcularDigitoCuit(string cuit) {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++) {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        public static bool ValidacionCuit(string cuit) {
            if (cuit == null) {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11) {
                return false;
            } else {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        //Para mostrar mensaje de confirmación
        public static void MesanjeCorrecto(string mensaje) {
            MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MesanjeError(string mensaje) {
            MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool MesanjeConsulta(string mensaje) {
            if (MessageBox.Show(mensaje, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                return true;
            } else {
                return false;
            }
            // MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // MessageBox.Show ("Do you want to exit?", "My Application",  MessageBoxButtons.YesNo, MessageBoxIcon.Question)  
        }

        public static void MesanjeAdvertencia(string mensaje) {
            MessageBox.Show(mensaje, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static Boolean ValidacionEmail(String email) {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion)) {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0) {
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
