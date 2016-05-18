using System;
using System.Linq;

class MultiplyTargetedCell
{
    static void Main()
    {
        // Get matrix coordinates.
        int[] sizeCoordinates = Console.ReadLine().Split(' ')
                                                  .Select(int.Parse)
                                                  .ToArray();
        int row = sizeCoordinates[0];
        int col = sizeCoordinates[1];
        long[,] matrix = new long[row, col];
        
        // Fill matrix cells.
        FillMatrix(row, col, matrix);

        int[] targetCoordinates = Console.ReadLine().Split(' ')
                                                    .Select(int.Parse)
                                                    .ToArray();
        int targetRow = targetCoordinates[0];
        int targetCol = targetCoordinates[1];
        long value = 0;//ReturnIncreaseValue(row, col, matrix, targetRow, targetCol);
        
        // Get max start and end row.
        int startRow = Math.Max(0, targetRow - 1);
        int endRow = Math.Min(targetRow + 1, row - 1);

        // Get max start and end col.
        int startCol = Math.Max(0, targetCol - 1);
        int endCol = Math.Min(targetCol + 1, col - 1);

        // Change values in matrix cells around bomb coordinates.
        for (int r = startRow; r <= endRow; r++)
        {
            for (int c = startCol; c <= endCol; c++)
            {

                value += matrix[r, c];
                if (r == targetRow && c == targetCol)
                {
                    continue;
                }
                else
                {
                    matrix[r, c] *= matrix[targetRow,targetCol];
                }
            }
        }

        // Calculate matrix target cell.
        matrix[targetRow, targetCol] *= value;

        // Print final matrix.
        PrintChosenMatrix(matrix);
    }

    static void FillMatrix(int row, int col, long[,] matrix)
    {
        for (int r = 0; r < row; r++)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(int.Parse)
                                              .ToArray();
            for (int c = 0; c < col; c++)
            {
                matrix[r, c] = numbers[c];
            }
        }
    }

    static void PrintChosenMatrix(long[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}
