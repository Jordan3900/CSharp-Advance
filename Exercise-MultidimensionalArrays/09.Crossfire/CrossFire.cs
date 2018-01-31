using System;
using System.Linq;
using System.Collections.Generic;
namespace _09.Crossfire
{
    class Crossfire
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = FillMatrix(rows,cols );
            var command = Console.ReadLine();
            while (command != "Nuke it from orbit")
            {
                var commandTokens = command.Split(' ').Select(int.Parse).ToArray();
                var rowImpact = commandTokens[0];
                var colImpact = commandTokens[1];
                int radius = commandTokens[2];

                for (int rowIndex = rowImpact-radius; rowIndex <= rowImpact+radius; rowIndex++)
                {
                    if (IsMatrix(rowIndex,colImpact,matrix))
                    {
                        matrix[rowIndex][colImpact] = -1;
                    }
                }
                for (int colIndex = colImpact-radius; colIndex <= colImpact+radius; colIndex++)
                {
                    if (IsMatrix(rowImpact, colIndex , matrix))
                    {
                        matrix[rowImpact][colIndex] = -1;
                    }
                }
                FilterMatrix(matrix);
                
                command = Console.ReadLine();
            }
            PrintMatrix(matrix);
        }

        private static void FilterMatrix(List<List<int>> matrix)
        {
            for (int rowIndex = matrix.Count-1; rowIndex >=  0; rowIndex--)
            {
                for (int colIndex = matrix[rowIndex].Count-1; colIndex >= 0 ; colIndex--)
                {
                    if (matrix[rowIndex][colIndex] == -1)
                    {
                        matrix[rowIndex].RemoveAt(colIndex);
                    }
                }
                if (matrix[rowIndex].Count == 0)
                {
                    matrix.RemoveAt(rowIndex);  
                }
            }
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                Console.WriteLine(string.Join(" ", matrix[rowIndex]));
            }
        }

        private static bool IsMatrix(int currentRow, int currentCol , List<List<int>> matrix)
        {
            if (currentRow >= 0 && currentRow < matrix.Count &&
                currentCol >= 0 && currentCol < matrix[currentRow].Count)
            {
                return true;
            }
            return false;
        }

        private static  List<List<int>> FillMatrix(int rows, int cols)
        {
            var matrix = new List<List<int>>();
            var counter = 1;
            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());
                for (int col = 0; col < cols; col++)
                {
                    matrix[row].Add(counter);
                    counter++;
                }
            }
            return matrix;
        }
    }
}
