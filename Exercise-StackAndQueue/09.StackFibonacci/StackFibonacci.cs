using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Stack<long> fibonacci = new Stack<long>();

            
            fibonacci.Push(1);
            fibonacci.Push(1);
            int a = 1;
            for (int i = 2; i < n; i++)
            {
                long fibPrev = fibonacci.Pop();
                long fibNext = fibonacci.Peek() + fibPrev;

                fibonacci.Push(fibPrev);
                fibonacci.Push(fibNext);
            }
            Console.WriteLine(fibonacci.Pop());
        }
    }
}
