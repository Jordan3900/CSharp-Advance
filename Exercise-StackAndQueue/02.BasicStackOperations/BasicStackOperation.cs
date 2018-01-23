using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperations
{
    class BasicStackOperation
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = parameters[0];
            int s = parameters[1];
            int x = parameters[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {

                Console.WriteLine(stack.Min());
                
            }

        }
    }
}
