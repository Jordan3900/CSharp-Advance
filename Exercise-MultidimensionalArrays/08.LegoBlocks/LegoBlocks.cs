using System;
using System.Linq;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var legoBlock1 = new int[n][];
            var legoBlock2 = new int[n][];

            for (int i = 0; i < n; i++)
            {
                legoBlock1[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                legoBlock2[i] = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToArray();
            }
            bool isMatch = false;
            for (int row = 0; row < n-1; row++)
            {
                if (legoBlock1[row].Length + legoBlock2[row].Length == legoBlock1[row+1].Length + legoBlock2[row+1].Length)
                {
                    isMatch = true;
                }
                else
                {
                    break;
                }
            }
            if (isMatch)
            {
                
                for (int i = 0; i < legoBlock1.Length; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", legoBlock1[i].Concat(legoBlock2[i]))}]");
                }
            }
            else
            {
                int cells = 0;
                for (int i = 0; i <legoBlock1.Length; i++)
                {
                    cells += legoBlock1[i].Length + legoBlock2[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {cells}");
            }
        }
    }
}
