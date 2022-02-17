using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_1_Capgemini
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor de N: ");

            bool var = false;
            int n = 0;

            while (var == false)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    var = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Informar um dado válido (número inteiro)");
                    Console.Write("Entre com o valor de N: ");
                }

            }
         
            for (int i = 0; i <= n; i++)
            {
                string linha = string.Empty;

                for (int x = i; x < n; x++)
                {
                    linha += " ";

                }

                int qtdasteriscos = n - linha.Length;

                for (int y = 0; y < qtdasteriscos; y++)
                {
                    linha += "*";
                    
                }
                    Console.WriteLine(linha);             
            }
            Console.ReadLine();
        }
    }
    }


