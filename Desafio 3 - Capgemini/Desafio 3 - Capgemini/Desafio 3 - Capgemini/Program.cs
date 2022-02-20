using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagramas
{
    public class Program
    {
        public static void Main()
        {
            bool palavraOuSequenciaDeLetrasValida = false;

            while (palavraOuSequenciaDeLetrasValida == false)
            {
                Console.WriteLine("Informe uma palavra ou sequencia de letras para calcular os anagramas pares: ");
                string? palavraOuSequenciaDeLetras = Console.ReadLine();
                if (!string.IsNullOrEmpty(palavraOuSequenciaDeLetras) && palavraOuSequenciaDeLetras.Length > 0)
                {
                    palavraOuSequenciaDeLetrasValida = true;

                    Console.WriteLine("Palavra ou sequencia informada: " + palavraOuSequenciaDeLetras);
                    Console.WriteLine("Quantidade de Anagramas: " + CalcularAnagramas(palavraOuSequenciaDeLetras));
                }
            }
        }

        public static int CalcularAnagramas(string palavraOuSequenciaDeLetras)
        {
            var index = 0;
            var quantidadeDeAnagramas = 0;
            var dicionarioDeAnagramas = new Dictionary<string, int>();
            var quantidadeDeLetras = palavraOuSequenciaDeLetras.Length;

            string[] listaDeAnagramas = new string[quantidadeDeLetras * (quantidadeDeLetras + 1) / 2];

            for (int i = 0; i < quantidadeDeLetras; i++)
            {
                for (int j = i; j < quantidadeDeLetras; j++)
                {
                    listaDeAnagramas[index] = palavraOuSequenciaDeLetras.Substring(i, j - i + 1);
                    index++;
                }
            }

            foreach (var anagrama in listaDeAnagramas)
            {
                var anagramaOrdenado = string.Concat(anagrama.OrderBy(x => x));

                if (dicionarioDeAnagramas.ContainsKey(anagramaOrdenado))
                    dicionarioDeAnagramas[anagramaOrdenado]++;
                else
                    dicionarioDeAnagramas[anagramaOrdenado] = 1;
            }

            foreach (var anagrama in dicionarioDeAnagramas.Keys)
            {
                if (dicionarioDeAnagramas[anagrama] > 1)
                    quantidadeDeAnagramas += dicionarioDeAnagramas[anagrama] * (dicionarioDeAnagramas[anagrama] - 1) / 2;
            }

            return quantidadeDeAnagramas;
        }
    }
}