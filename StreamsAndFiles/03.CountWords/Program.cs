using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace _03.CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCount = new Dictionary<string, int>();
            var reader = new StreamReader("Words.txt");
            using (reader)
            {
                while (true)
                {
                    var word = reader.ReadLine();
                    if (word == null)
                    {
                        break;
                    }
                    word = word.ToLower();
                    if (!wordsCount.ContainsKey(word))
                    {
                        wordsCount[word] = 0;
                    }
                }
            }
            var readTxt = new StreamReader("text.txt");
            using (readTxt)
            {
                while (true)
                {
                    var textLine = readTxt.ReadLine();
                    if (textLine == null)
                        break;
                    var words = textLine.Split(" .,?!:;-[]{}()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (wordsCount.ContainsKey(words[i].ToLower()))
                        {
                            wordsCount[words[i].ToLower()]++;
                        }
                    }

                }
            }

            var writer = new StreamWriter("Result.txt");
            using (writer)
            {
                var result = wordsCount.OrderByDescending(w => w.Value).Select(w => $"{w.Key} - {w.Value}");

                foreach (var item in result)
                {
                    writer.WriteLine(item);
                }
            }

        }
    }
}
