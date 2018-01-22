using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();
            int carsPassed = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    carsPassed += n;
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            if (cars.Count >= carsPassed)
            {
                
                for (int i = 0; i < carsPassed; i++)
                {
                    
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    
                }
            }
            else
            {
                carsPassed = cars.Count;
                for (int i = 0; i < carsPassed; i++)
                {
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                }
                
            }
            
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
