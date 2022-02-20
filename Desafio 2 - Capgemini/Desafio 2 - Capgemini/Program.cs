using System;

namespace Desafio_2___Capgemini
{
    /// <summary>
    /// Classe que irá fazer a interação com o usuário recebendo a senha digitada e mostrando
    /// a quantidade de digitos faltantes que é necessário caso a senha não atenda os requisitos mínimos.
    /// </summary>
    /// <see cref="Senha"/>

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
