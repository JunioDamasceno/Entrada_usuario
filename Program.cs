using System;

namespace entrada_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"\nÉ um prazer conhecê-lo {nome}!!!!");
            
            //O tipo "string" armazena variáveis do tipo string (textos)
            //O comando "Console.ReadLine()" recebe entradas do usuário no teclado
        }
    }
}
