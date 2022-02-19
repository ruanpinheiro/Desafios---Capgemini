using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_1_Capgemini
{
    class Program
    {
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


