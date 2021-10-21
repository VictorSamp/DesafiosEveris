using System;

namespace Quadrante
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int pontoX, pontoY;

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                pontoX = int.Parse(input[0]);
                pontoY = int.Parse(input[1]);

                if (pontoX == 0 || pontoY == 0)
                    break;
                else if (pontoX > 0 && pontoY > 0)
                    Console.WriteLine("primeiro");
                else if (pontoX < 0 && pontoY > 0)
                    Console.WriteLine("segundo");
                else if (pontoX < 0 && pontoY < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("quarto");
            }
        }
    }
}