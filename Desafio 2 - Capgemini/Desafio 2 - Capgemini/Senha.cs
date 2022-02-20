using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_2___Capgemini
{

    /// <summary>
    /// Método ValidaSenha usará um If para validar o tamanho da senha e 
    /// quatro regex para válidar se a senha possui números, letras minúsculas, letras maiúsculas e caracteres 
    /// especiais.
    /// </summary>
    /// <param name="senhaDigitada"> Parâmetro que irá receber a senha digitada pelo usuário na classe Program.</param>
    /// <value>a varíavel contador inteiro será responsável por contar a quantidade de itens obrigatórios
    /// que está faltando na senha digita.</value>
    /// <return>Retorna a quantidade de caracteres necessários para uma senha forte.</return>
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
