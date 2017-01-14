using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheatSheet
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int startRow = int.Parse(Console.ReadLine());
        int startCol = int.Parse(Console.ReadLine());

        long[,] matrix = new long[row, col];
        long start = (long)startRow * startCol;
        // Main Logic. In every column add start + row position + startRow multiply by column position.
        for (int rows = 0; rows < row; rows++)
        {
            for (int cols = 0; cols < col; cols++)
            {
                matrix[rows, cols] = start + (rows + startRow )* cols;
                Console.Write("{0} ", matrix[rows,cols]);
            }
            start += startCol; // The start value plus startCol value in the end of every row position.
            Console.WriteLine();
        }
    }
}
