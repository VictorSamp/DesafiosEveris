using System;

namespace Pneu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int pressaoDesejada = int.Parse(Console.ReadLine());
            int pressaoAtual = int.Parse(Console.ReadLine());

            int diferencaPressao = pressaoDesejada - pressaoAtual;

            Console.WriteLine(diferencaPressao);
        }
    }
}