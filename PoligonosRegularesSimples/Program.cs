using System;

namespace PoligonosRegularesSimples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int quantidadeDeLados = int.Parse(entrada[0]);
            int comprimentoDoLado = int.Parse(entrada[1]);

            int perimetro = quantidadeDeLados * comprimentoDoLado;

            Console.WriteLine(perimetro);
        }
    }
}