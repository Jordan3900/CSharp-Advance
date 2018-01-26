using System;
using System.Linq;
namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int countOfMatrix = int.Parse(Console.ReadLine());
            int[][] matrix = new int[countOfMatrix][];
            for (int i = 0; i < countOfMatrix; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            }
            int[] primaryDiagonal = new int[countOfMatrix];
            int[] secondaryDiagonal = new int[countOfMatrix];
            for (int i = 0; i < countOfMatrix; i++)
            {
                primaryDiagonal[i] = matrix[i][i];
            }
            for (int i = 0, j = countOfMatrix-1; i < countOfMatrix; i++, j--)
            {
                secondaryDiagonal[i] = matrix[i][j];
            }
            Console.WriteLine(Math.Abs(primaryDiagonal.Sum() - secondaryDiagonal.Sum()));
        }
    }
}
