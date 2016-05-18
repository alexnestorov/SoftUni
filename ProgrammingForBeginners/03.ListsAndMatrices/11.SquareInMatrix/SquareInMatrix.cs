using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareInMatrix
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int row = input[0];
        int col = input[1];
        string[,] matrix = new string[row, col];
        string[] phrase = new string[row * col];
        FillTheMatrix(row, col, matrix, phrase);

        int count = 0;
        count = CountSquaresInMatrix(row, col, matrix, count, phrase);
        Console.WriteLine(count);
    }

    static int CountSquaresInMatrix(int row, int col, string[,] matrix, int count, string[] phrase)
    {
        for (int r = 1; r <= row - 1; r++)
        {
            for (int c = 1; c <= col - 1; c++)
            {
                if (matrix[r, c - 1] == matrix[r - 1, c] && matrix[r - 1, c - 1] == matrix[r, c] &&
                    matrix[r - 1, c - 1] == matrix[r - 1, c] && matrix[r, c - 1] == matrix[r, c]) // Check for equal letters in all four posittions
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void FillTheMatrix(int row, int col, string[,] matrix, string[] phrase)
    {
        for (int r = 0; r < row; r++)
        {
            phrase = Console.ReadLine().Split(' ').ToArray();
            for (int c = 0; c < col; c++)
            {
                matrix[r, c] = phrase[c].ToString();
            }
        }
    }
}
