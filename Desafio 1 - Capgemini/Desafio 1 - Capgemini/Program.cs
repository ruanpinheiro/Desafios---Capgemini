using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_1_Capgemini
{
    
    class Program
    {
        /// <summary>
        /// Classe que irá realizar a interação com o usuário para receber o valor
        /// da árvore e ao final imprimir a árvore no console.
        /// <see cref="ArvoreDeAsterisco"/>
        /// </summary>
        /// <value> n é o inteiro que vai receber o valor que o usuário digitar.</value> 
        /// <exception cref="Exception"> Exceção que caso o usuário não digite um inteiro, cairá no while até digitar
        /// o valor válido.</exception>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ArvoreDeAsterisco arvoreDeAsterisco = new();

            Console.Write("Entre com o valor de N: ");

            bool var = false;
            int n = 0;

            while (var == false)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    arvoreDeAsterisco.GerarArvore(n);
                    var = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Informar um dado válido (número inteiro)");
                    Console.Write("Entre com o valor de N: ");
                }

            }
                 
        }
    }
    }


