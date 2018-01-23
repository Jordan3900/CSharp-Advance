using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxValues = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (queries[0] == 1)
                {
                    numbers.Push(queries[1]);
                    if (maxValues < queries[1])
                    {
                        maxValues = queries[1];
                        maxNumbers.Push(queries[1]);
                    }
                }
                else if (queries[0] == 2)
                {
                    if (numbers.Pop() == maxValues)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count != 0)
                        {
                            maxValues = maxNumbers.Peek();
                        }
                        else
                        {
                            maxValues = int.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxValues);
                }
            }
        }
    }
}
