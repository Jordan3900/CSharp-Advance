using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
             
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split()/*.Select(int.Parse).ToArray()*/);

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
