using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1_Capgemini
{
    ///<summary> 
    ///Método para gerar a árvore de asteriscos. Possui três FOR, o primeiro responsável gerenciar
    ///os dois subsequentes. O segundo é responsável por acrescentar os espaços em branco e o terceiro é responsável 
    ///por acrescentar os asteriscos.
    ///</summary>
    ///<param name="n">Parâmetro que recebe o inteiro que o usuário digitou para gerar a árvore.</param>   
    ///<value>qtdasteriscos inteiro será utilizado para receber a diferença da quantidade de espaços inseridos na string linha
    ///e irá entrar na fórmula do terceiro para inserir os asteriscos.</value>
    ///<returns>Retorna uma cadeia de strings com os espaços e asteriscos formando a árvore.</returns>
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
