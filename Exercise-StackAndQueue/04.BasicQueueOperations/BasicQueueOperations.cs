using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            int n = parameters[0];
            int s = parameters[1];
            int x = parameters[2];

            

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
