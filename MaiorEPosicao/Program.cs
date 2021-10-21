using System;

namespace MaiorEPosicao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int entrada;
            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                entrada = Convert.ToInt32(Console.ReadLine());
                if (entrada > maior)
                {
                    maior = entrada;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}