using System;

namespace Desafio_2___Capgemini
{
    class Program
    {
        static void Main(string[] args)
        {

            Senha senhaValida = new Senha();

            Console.WriteLine("Digite uma senha válida: ");
            var caracteresFaltantes = senhaValida.ValidaSenha(Console.ReadLine());
            Console.WriteLine("\n" + caracteresFaltantes);

        }
    }
}
