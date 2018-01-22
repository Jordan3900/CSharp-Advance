using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (num != 0)
            {
                stack.Push(num % 2);
                num /= 2;
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
