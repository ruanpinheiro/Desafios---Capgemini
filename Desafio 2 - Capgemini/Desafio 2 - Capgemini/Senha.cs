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
        public string SenhaVálida { get; set; }

        public Senha(string senhaVálida)
        {
            SenhaVálida = senhaVálida;
        }
        public bool ValidaSenha(string senhaDigitada)
        {
            if (senhaDigitada.Length != 6)
            {
                return false;
            }
            
            Regex regex = new Regex("[0-9]");

            if (regex.IsMatch(senhaDigitada) == false){

            }

        }
    }
}
