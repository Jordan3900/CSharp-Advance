using System;
using System.IO;
namespace _02.LineNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine($"Line {lineNumber}: {line}");
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
