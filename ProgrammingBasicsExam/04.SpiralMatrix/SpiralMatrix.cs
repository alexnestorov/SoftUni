using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpiralMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string phrase = Console.ReadLine();
        int max = size * size;
        int[,] matrix = new int[size, size];
        int row = 0;
        int col = 0;
        string startDirection = "right";
        for (int i = 0; i < max; i++)
        {
            // Switch direction if row and col are outside of the matrix
            SwitchDirections(size, matrix, ref row, ref col, ref startDirection);
            //Get value to fill each matrix position.
            int fillSize = GetValueFillSize(phrase, i);
            matrix[row, col] = fillSize * 10;
            // Update row or col according to startDirection.
            SetDirectionMove(ref row, ref col, startDirection);
        }
        // Find max sum value row of all rows
        int maxRowValue, biggestRow;
        GetMaxValueRow(size, matrix, out maxRowValue, out biggestRow);
        Console.WriteLine("{0} - {1}", biggestRow, maxRowValue);
    }

    static void GetMaxValueRow(int size, int[,] matrix, out int maxRowValue, out int biggestRow)
    {
        maxRowValue = int.MinValue;
        biggestRow = 0;
        for (int i = 0; i < size; i++)
        {
            int rowValue = 0;
            for (int j = 0; j < size; j++)
            {
                int colValue = matrix[i, j];
                rowValue += colValue;
            }
            if (maxRowValue < rowValue)
            {
                maxRowValue = rowValue;
                biggestRow = i;
            }

        }
    }

    static int GetValueFillSize(string phrase, int i)
    {
        int index = i % (phrase.Length);
        int fillSize = phrase[index];
        if (fillSize > 90)
        {
            fillSize = phrase[index] - 'a' + 1;
        }
        else if (fillSize <= 90)
        {
            fillSize = phrase[index] - 'A' + 1;
        }

        return fillSize;
    }

    static void SwitchDirections(int size, int[,] matrix, ref int row, ref int col, ref string startDirection)
    {
        if (startDirection == "right" && (col > size - 1 || matrix[row, col] != 0))
        {
            col--;
            row++;
            startDirection = "down";
        }
        else if (startDirection == "down" && (row > size - 1 || matrix[row, col] != 0))
        {
            col--;
            row--;
            startDirection = "left";
        }
        else if (startDirection == "left" && (col < 0 || matrix[row, col] != 0))
        {
            col++;
            row--;
            startDirection = "up";
        }
        else if (startDirection == "up" && (row < 0 || matrix[row, col] != 0))
        {
            col++;
            row++;
            startDirection = "right";
        }
    }

    static void SetDirectionMove(ref int row, ref int col, string startDirection)
    {
        if (startDirection == "down")
        {
            row++;
        }
        else if (startDirection == "right")
        {
            col++;
        }
        else if (startDirection == "up")
        {
            row--;
        }
        else if (startDirection == "left")
        {
            col--;
        }
    }
}
