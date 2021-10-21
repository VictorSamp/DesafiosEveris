using System;

namespace HoHoHo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int quantidadeDeHo = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeDeHo; i++)
            {
                if (i < quantidadeDeHo - 1)
                {
                    Console.Write("Ho ");
                }
                else
                {
                    Console.Write("Ho!");
                }
            }
        }
    }
}