using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BunkerBuster
{
    static void Main()
    {
        int row, col;
        int[,] matrix;
        MatrixSizeCoordinates(out row, out col, out matrix);
        FillCellsInMatrix(row, col, matrix);
        string input = Console.ReadLine();
        //string[] bombCoordinates = CoordinatesValue(input);
        string[] bombCoordinates;
        int targetRow, targetCol;
        char power;
        BombCoordinates(input, out bombCoordinates, out targetRow, out targetCol, out power);

        // Main Logic. In each cycle find matrix coordinates to bomb.
        while (input != "cease fire!")
        {
            
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

                    if (r == targetRow && c == targetCol)
                    {
                        matrix[r, c] -= power;
                    }
                    else
                    {
                        double decreaseValue = Math.Ceiling(power / 2.0);
                        matrix[r, c] -= (int)decreaseValue;
                    }
                }
            }
            input = Console.ReadLine();
            if (input == "cease fire!")
            {
                break;
            }
            BombCoordinates(input, out bombCoordinates, out targetRow, out targetCol, out power);
        }

        //Output
        int destroyedBunkers = CountDestroyedBunkers(matrix);
        double damageDone = (double)destroyedBunkers / (row * col);
        Console.WriteLine("Destroyed bunkers: {0}", destroyedBunkers);
        Console.WriteLine("Damage done: {0:F1} %", damageDone * 100);
    }

    static void BombCoordinates(string input, out string[] bombCoordinates, out int targetRow, out int targetCol, out char power)
    {
        bombCoordinates = input.Split(' ').ToArray();
        targetRow = int.Parse(bombCoordinates[0].ToString());
        targetCol = int.Parse(bombCoordinates[1].ToString());
        power = char.Parse(bombCoordinates[2].ToString());
    }

    static void MatrixSizeCoordinates(out int row, out int col, out int[,] matrix)
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        row = matrixSize[0];
        col = matrixSize[1];
        matrix = new int[row, col];
    }

    static string[] CoordinatesValue(string input)
    {
        string[] bombCoordinates = input.Split(' ').ToArray();
        int targetRow = int.Parse(bombCoordinates[0].ToString());
        int targetCol = int.Parse(bombCoordinates[1].ToString());
        char power = char.Parse(bombCoordinates[2].ToString());
        return bombCoordinates;
    }

    static void FillCellsInMatrix(int row, int col, int[,] matrix)
    {
        for (int i = 0; i < row; i++)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }
    }

    static int CountDestroyedBunkers(int[,] matrix)
    {
        int temp = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows,cols] <= 0)
                {
                    temp++;
                }
                //Console.Write("{0} ", matrix[rows, cols]);
            }
            //Console.WriteLine();
        }
        return temp;
    }
}
