using System;

namespace _04.PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            long height = long.Parse(Console.ReadLine());
         
            long[][] triangle = new long[height][];
            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new long[currentHeight + 1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;
                if (currentHeight >= 2)
                {
                    for (int widhtCounter = 1; widhtCounter < currentHeight; widhtCounter++)
                    {
                        triangle[currentHeight][widhtCounter] = triangle[currentHeight - 1][widhtCounter - 1] +
                        triangle[currentHeight - 1][widhtCounter];    
                            
                    }
                }

            }
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write(triangle[row][col] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
