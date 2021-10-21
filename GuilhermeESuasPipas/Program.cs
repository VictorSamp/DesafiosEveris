using System;

namespace GuilhermeESuasPipas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int resposta = (entrada * (entrada - 3)) / 2;
            Console.WriteLine(resposta);
        }
    }
}