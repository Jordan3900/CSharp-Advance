using System;
using System.Linq;
namespace _01._MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] colRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[colRow[0], colRow[1]];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < colRow[0]; row++)
            {
                int countOfMiddleLetter = row;
                for (int col = 0; col < colRow[1]; col++)
                {
                    string str = string.Empty;
                    
                    str += alphabet[row];
                    str += alphabet[countOfMiddleLetter];
                    str += alphabet[row];
                    
                    matrix[row, col] = str;
                    countOfMiddleLetter++;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
