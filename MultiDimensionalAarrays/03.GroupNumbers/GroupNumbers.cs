using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ',' }).Select(int.Parse).ToArray();
            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                sizes[Math.Abs(number) % 3]++;
            }
            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < sizes.Length; i++)
            {
                jaggedArray[i] = new int[sizes[i]];
            }
            int[] index = new int[3];
            foreach (var number in numbers)
            {
                var reminder = Math.Abs(number) % 3;
                jaggedArray[reminder][index[reminder]] = number;
                index[reminder]++;
            }
            Console.WriteLine(string.Join(" ", jaggedArray[0]));
            Console.WriteLine(string.Join(" ", jaggedArray[1]));
            Console.WriteLine(string.Join(" ", jaggedArray[2]));
        }
    }
}
