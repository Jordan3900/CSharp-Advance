using System;
using System.Linq;
namespace _02.SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] colsAndRows = Console.ReadLine().Split(new char[] { ',' }).Select(int.Parse).ToArray();
            int[,] matrix = new int[colsAndRows[0], colsAndRows[1]];
            int[] top = new int[2];
            int[] bottom = new int[2];
            int maxSum = int.MinValue;

            for (int row = 0; row < colsAndRows[0]; row++)
            {
                int[] rowValues = Console.ReadLine().Split(new char[] { ',' }).Select(int.Parse).ToArray();
                for (int col = 0; col < colsAndRows[1]; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row,col] + matrix[row,col+1] + matrix[row+1,col] + matrix[row + 1, col+1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        top[0] = matrix[row, col];
                        top[1] = matrix[row, col + 1];
                        bottom[0] = matrix[row+1, col];
                        bottom[1] = matrix[row+1, col + 1];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",top));
            Console.WriteLine(string.Join(" ", bottom));
            Console.WriteLine(maxSum);
        }
    }
}
