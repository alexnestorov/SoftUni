using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BlurFilter
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] matrixSize = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long row = matrixSize[0];
        long col = matrixSize[1];
        long[,] matrix = new long[row, col];

        FillMatrix(row, col, matrix);
        long[] target = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long targetRow = target[0];
        long targetCol = target[1];
        matrix[targetRow, targetCol] += n;
        CheckMatrixIsoutsideOfBorder(n, row, col, matrix, targetRow, targetCol);
        PrintFinalMatrix(matrix);
    }

    private static void FillMatrix(long row, long col, long[,] matrix)
    {
        for (long i = 0; i < row; i++)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            for (long j = 0; j < col; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }
    }

    private static void CheckMatrixIsoutsideOfBorder(long n, long row, long col, long[,] matrix, long targetRow, long targetCol)
    {
        if (targetCol + 1 < col && targetRow + 1 < row)
        {
            matrix[targetRow + 1, targetCol + 1] += n;
        }
        if (targetCol + 1 < col)
        {
            matrix[targetRow, targetCol + 1] += n;
        }
        if (targetCol + 1 < col && targetRow - 1 >= 0)
        {
            matrix[targetRow - 1, targetCol + 1] += n;

        }
        if (targetCol - 1 >= 0 && targetRow + 1 < row)
        {
            matrix[targetRow + 1, targetCol - 1] += n;
        }
        if (targetCol - 1 >= 0)
        {
            matrix[targetRow, targetCol - 1] += n;

        }
        if (targetCol - 1 >= 0 && targetRow - 1 >= 0)
        {
            matrix[targetRow - 1, targetCol - 1] += n;

        }
        if (targetRow + 1 < row)
        {
            matrix[targetRow + 1, targetCol] += n;

        }
        if (targetRow - 1 >= 0)
        {
            matrix[targetRow - 1, targetCol] += n;
        }
    }

    private static void PrintFinalMatrix(long[,] matrix)
    {
        for (long rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (long cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}
