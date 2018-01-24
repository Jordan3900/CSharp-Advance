using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            Stack<string> textHoleder = new Stack<string>();


            Console.WriteLine(builder);
            for (int i = 0; i < n; i++)
            {
                string[] operations = Console.ReadLine().Split();
                int operation = int.Parse(operations[0]);
                switch (operation)
                {
                    case 1:
                        builder.Append(operations[1]);
                            textHoleder.Push(builder.ToString());
                        break;
                    case 2:
                        builder.Remove(0, int.Parse(operations[1]));
                            textHoleder.Push(builder.ToString());
                        break;
                    case 3:
                        Console.WriteLine(builder[int.Parse(operations[1]) - 1]); ;
                        break;
                    case 4:
                        builder.Clear();
                        textHoleder.Pop();
                        builder.Append(textHoleder.Peek());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
