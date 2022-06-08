using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Un valor >> ");
            int num = Convert.ToInt32(Console.ReadLine());

            Serie fibonacci = new Serie();
            int[] fib = fibonacci.CalculateSeries(num);

            for (int i = 0; i < fib.Length; i++)
            {
                Console.Write(fib[i] + " ");
            }
        }
    }
}
