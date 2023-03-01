using System;

namespace LerNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine("Nao negativo");
            }
            else 
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
