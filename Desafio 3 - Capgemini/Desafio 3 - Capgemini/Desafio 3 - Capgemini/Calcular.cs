using System.Collections.Generic;
using System.Linq;

namespace Desafio_3___Capgemini
{
    class Calcular
    {
        /// <summary>
        /// Classe responsável por calcular e ao final retornar um inteiro de quantos anagramas a palavra
        /// passada como parâmetro possui. Nesta estrutura teremos dois for para percorrer o vetor, o primeiro
        /// foreach para adicionar o anagrama no vetor e o segundo foreach para calcular a quantidade de 
        /// anagramas do vetor.
        /// </summary>
        /// <param name="palavraOuSequenciaDeLetras"> Parâmetro que recebe da classe Program a palavra que o
        /// usuário digitou.</param>
        /// <returns></returns>

        public int CalcularAnagramas(string palavraOuSequenciaDeLetras)
        {
            int index = 0;
            int quantidadeDeAnagramas = 0;
            var dicionarioDeAnagramas = new Dictionary<string, int>();
            int quantidadeDeLetras = palavraOuSequenciaDeLetras.Length;

            string[] listaDeAnagramas = new string[quantidadeDeLetras * (quantidadeDeLetras + 1) / 2];

            for (int i = 0; i < quantidadeDeLetras; i++)
            {
                for (int j = i; j < quantidadeDeLetras; j++)
                {
                    listaDeAnagramas[index] = palavraOuSequenciaDeLetras.Substring(i, j - i + 1);
                    index++;
                }
            }

            foreach (string anagrama in listaDeAnagramas)
            {
                string anagramaOrdenado = string.Concat(anagrama.OrderBy(x => x));

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
