using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1_Capgemini
{
    public class ArvoreDeAsterisco
    {

        public void GerarArvore(int n)
        {

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
