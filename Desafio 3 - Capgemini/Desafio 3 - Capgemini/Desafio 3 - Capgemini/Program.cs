using Desafio_3___Capgemini;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagramas
{
    /// <summary>
    /// Classe responsavel por fazer a interação com usuário recebendo a palavra ou sequncia de letras para retornar
    /// a quantidade de anagramas que essa palavra ou sequência de letras possui.
    /// <see cref="Calcular"/>
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            bool palavraOuSequenciaDeLetrasValida = false;
            Calcular calcular = new Calcular();

            while (palavraOuSequenciaDeLetrasValida == false)
            {
                Console.WriteLine("Informe uma palavra ou sequencia de letras para calcular os anagramas pares: ");
                string? palavraOuSequenciaDeLetras = Console.ReadLine();
                if (!string.IsNullOrEmpty(palavraOuSequenciaDeLetras) && palavraOuSequenciaDeLetras.Length > 0)
                {
                    palavraOuSequenciaDeLetrasValida = true;

                    Console.WriteLine("Palavra ou sequencia informada: " + palavraOuSequenciaDeLetras);
                    Console.WriteLine("Quantidade de Anagramas: " + calcular.CalcularAnagramas(palavraOuSequenciaDeLetras));
                }
            }
        }

        
    }
}