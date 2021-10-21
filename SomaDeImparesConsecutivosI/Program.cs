using System;

namespace SomaDeImparesConsecutivosI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int entrada1, entrada2, minimo, maximo, soma;

            entrada1 = int.Parse(Console.ReadLine());
            entrada2 = int.Parse(Console.ReadLine());

            if (entrada1 < entrada2)
            {
                minimo = entrada1;
                maximo = entrada2;
            }
            else
            {
                minimo = entrada2;
                maximo = entrada1;
            }

            soma = 0;
            for (int i = minimo + 1; i < maximo; i++)
            {
                if (i % 2 != 0)
                {
                    soma = i;     //complete o código nos espaços em branco
                }
            }

            Console.WriteLine(soma);
        }
    }
}