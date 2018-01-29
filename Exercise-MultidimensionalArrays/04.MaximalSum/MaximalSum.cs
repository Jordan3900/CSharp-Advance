using System;
using System.Linq;
namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];


            for (int col = 0; col < matrixSizes[0]; col++)
            {
                int[] input = Console.ReadLine()
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                for (int row = 0; row < matrixSizes[1]; row++)
                {
                    matrix[col, row] = input[row];
                }
            }
            int maxSum = int.MinValue;
            int rowStartIndex = 0;
            int colStartIndex = 0;
            
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <matrix.GetLength(1) - 2; col++)
                {
                    int matrixSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (maxSum < matrixSum)
                    {
                        maxSum = matrixSum;
                        rowStartIndex = row;
                        colStartIndex = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowStartIndex; row <= rowStartIndex+2; row++)
            {
                for (int col = colStartIndex; col <= colStartIndex+2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
