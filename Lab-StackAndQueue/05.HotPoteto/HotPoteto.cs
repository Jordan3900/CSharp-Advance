using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HotPoteto
{
    class HotPoteto
    {
        static void Main(string[] args)
        {
            Queue<string> persons = new Queue<string>(Console.ReadLine().Split());
            int count = int.Parse(Console.ReadLine());
            while (persons.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    persons.Enqueue(persons.Dequeue());
                }
                Console.WriteLine($"Removed {persons.Dequeue()}");
            }
            Console.WriteLine($"Last is {persons.Dequeue()}");
        }
    }
}
