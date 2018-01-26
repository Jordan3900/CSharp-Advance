using System;
using System.Linq;
namespace _03._2x2SquaresInMatrix
{
    class EqualSqaureInMatrix
    {
        static void Main(string[] args)
        {
            int[] colRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[colRow[0], colRow[1]];

            for (int row = 0; row < colRow[0]; row++)
            {
                string[] characters = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < colRow[1]; col++)
                {
                    matrix[row, col] = characters[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < colRow[0]-1; row++)
            {
                for (int col = 0; col < colRow[1]-1; col++)
                {
                    if (matrix[row,col] == (matrix[row+1,col]) &&
                        matrix[row,col+1].Equals(matrix[row+1,col+1]) &&
                        matrix[row, col] == (matrix[row , col+1]) &&
                        matrix[row, col] == (matrix[row+1, col + 1]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
