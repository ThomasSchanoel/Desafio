using System;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (PertenceFib(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
            }

        }

        static bool PertenceFib(int num)
        {
            int a = 0, b = 1, c = 0;

            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == num || num == 0;
        }
    }
}