using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            int countOfPlants = int.Parse(Console.ReadLine());
            List<long> plants = Console.ReadLine().Split().Select(long.Parse).ToList();
            Stack<long> deathPlants = new Stack<long>();
            int days = 0;
            while (plants.Count > 1)
            {
                for (int i = plants.Count-1; i > 0; i--)
                {
                    if (plants[i]>plants[i-1])
                    {
                        deathPlants.Push(plants[i]);
                    }
                }
                if (deathPlants.Count > 0)
                {
                    int deathCount = deathPlants.Count;
                    for (int i = 0; i < deathCount; i++)
                    {
                        plants.Remove(deathPlants.Pop());
                    }
                }
                else
                {
                    break;
                }


                days++;
            }
            Console.WriteLine(days);
        }
    }
}
