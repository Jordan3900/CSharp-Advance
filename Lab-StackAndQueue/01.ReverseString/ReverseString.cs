using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseString = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverseString.Push(input[i]);
            }
            for (int i = 0; i <input.Length; i++)
            {
                Console.Write(reverseString.Pop());
            }
            Console.WriteLine();
        }
    }
}
