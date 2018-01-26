using System;
using System.Linq;
namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(new char[] { ',' }).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];

            for (int row = 0; row < rowAndCol[0]; row++)
            {
                int[] rowValues = Console.ReadLine().Split(new char[] { ','}).Select(int.Parse).ToArray();
                for (int col = 0; col < rowAndCol[1]; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(rowAndCol[0]);
            Console.WriteLine(rowAndCol[1]);
            Console.WriteLine(sum);
        }
    }
}
