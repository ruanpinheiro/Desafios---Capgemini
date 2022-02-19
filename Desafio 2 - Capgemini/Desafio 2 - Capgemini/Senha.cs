using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_2___Capgemini
{
       public class Senha
       {
      
        public int ValidaSenha(string senhaDigitada)
        {
            
            int contador = 0;

            if (senhaDigitada.Length < 6)
            {
                int caracteresFaltantes = 6 - senhaDigitada.Length;              
                return caracteresFaltantes;
            }

            Regex regex = new Regex("[0-9]");

            if (regex.IsMatch(senhaDigitada) == false)
            {
                contador++;
            }

            regex = new Regex("[a-z]");

            if (regex.IsMatch(senhaDigitada) == false)
            {
                contador++;
            }

            regex = new Regex("[A-Z]");

            if (regex.IsMatch(senhaDigitada) == false)
            {
                contador++;
            }

            regex = new Regex(@"[!@#$%^&*()-+]");

            if (regex.IsMatch(senhaDigitada) == false)
            {
                contador++;
            }         

            return contador;

        }
       }
}
