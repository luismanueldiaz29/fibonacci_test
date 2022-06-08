using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class Serie
    {
        public Serie() { }

        public int[] CalculateSeries(int num)
        {
            int[] fib = new int[num];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < num; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib;
        }
    }
}
