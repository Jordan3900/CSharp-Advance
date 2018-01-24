using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            char[] parentheses = Console.ReadLine().ToCharArray();
            Stack<char> openedParentheses = new Stack<char>();
            char[] openingParentheses = new char[] { '(', '[', '{' };

            for (int i = 0; i < parentheses.Length; i++)
            {
                if (openingParentheses.Contains(parentheses[i]))
                {
                    openedParentheses.Push(parentheses[i]);
                }
                else
                {
                    if (openedParentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (parentheses[i])
                    {
                        case ']':
                            if (openedParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (openedParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        default:
                            break;
                    }
                }
               
            }
            if (openedParentheses.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
