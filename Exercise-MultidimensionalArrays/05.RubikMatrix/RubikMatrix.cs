using System;
using System.Linq;

namespace _05.RubikMatrix
{
    class RubikMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var row = sizes[0];
            var col = sizes[1];
            var matrix = new int[row][];
            var count = 1;
            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                matrix[rowIndex] = new int[col];
                for (int colIndex = 0; colIndex <  col; colIndex++)
                {
                    matrix[rowIndex][colIndex] = count;
                    count++;
                }
            }
            var commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                var commandsToken = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var colRowIndex = int.Parse(commandsToken[0]);
                var direction = commandsToken[1];
                var moves = int.Parse(commandsToken[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, colRowIndex, moves);
                        break;
                    case "down":
                        MoveCol(matrix, colRowIndex, matrix.Length - moves);
                        break;
                    case "left":
                        MoveRow(matrix, colRowIndex, moves);
                        break;
                    case "right":
                        MoveRow(matrix, colRowIndex, matrix[0].Length - moves);
                        break;
                    default:
                        break;
                }
                var element = 1;
                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == element)
                        {
                            Console.WriteLine("No swap required");
                        }
                        else
                        {
                            for (int r = 0; r < matrix.Length; r++)
                            {
                                for (int c = 0; c < matrix[0].Length; c++)
                                {
                                    if (matrix[r][c]== element)
                                    {
                                        var currentElement = matrix[rowIndex][colIndex];
                                        matrix[rowIndex][colRowIndex] = element;
                                        matrix[r][c] = currentElement;
                                        Console.WriteLine($"Swap ({rowIndex},{colIndex}) with ({r}, {c})");
                                        break;
                                    }
                                }
                            }
                            
                        }
                        element++;
                    }
                }
            }
          
        }

        private static void MoveRow(int[][] matrix, int colRowIndex, int moves)
        {
            var temp = new int[matrix.Length];
            for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
            {
                temp[colIndex] = matrix[colRowIndex][(colIndex+moves) % matrix[0].Length];

            }
            matrix[colRowIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int colRowIndex, int moves)
        {
            var temp = new int[matrix.Length];
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
               temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][colRowIndex];
            }
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][colRowIndex] = temp[rowIndex];
            }
            
        }
    }
}
