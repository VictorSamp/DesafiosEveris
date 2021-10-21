using System;

namespace PUM
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            int contador = 1;

            for (int i = 0; i < entrada; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (contador % 4 == 0)
                    {
                        Console.WriteLine("PUM");
                    }
                    else
                    {
                        Console.Write($"{contador} ");
                    }

                    contador++;
                }
            }
        }
    }
}