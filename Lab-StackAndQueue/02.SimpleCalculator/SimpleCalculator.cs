using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split();
            Stack<string> stack = new Stack<string>(values.Reverse());

            for (int i = 0; i < values.Length; i++)
            {
                if (stack.Count > 1)
                {
                    int firstN = int.Parse(stack.Pop());
                    string operand = stack.Pop();
                    int secondN = int.Parse(stack.Pop());

                    switch (operand)
                    {
                        case "+":
                            stack.Push((firstN + secondN).ToString());
                            break;
                        case "-":
                            stack.Push((firstN - secondN).ToString());
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
