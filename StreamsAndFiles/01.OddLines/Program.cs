using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if(lineNumber % 2 != 0)
                        Console.WriteLine($"Line {lineNumber}: {line}");
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
