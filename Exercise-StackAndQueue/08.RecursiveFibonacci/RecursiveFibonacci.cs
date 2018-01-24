using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
              Fibonacci(0, 1, 1, n);
            
        }

        private static void Fibonacci(long a, long b, long counter, long n)
        {
            
            if (counter<=n)
            {
                Fibonacci(b, a + b, counter + 1, n);
            }
            else
            {
                Console.WriteLine(a);
            }

            
            
        }
    }
}
