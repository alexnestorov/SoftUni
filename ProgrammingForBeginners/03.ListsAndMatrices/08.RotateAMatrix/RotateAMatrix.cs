using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateAMatrix
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, col];

        for (int r = 0; r < row; r++)
        {
            string[] phrase = Console.ReadLine().Split(' ').ToArray();
            for (int c = 0; c < col; c++)
            {
                matrix[r, c] = phrase[c].ToString();
            }
        }
        // Print matrix reversing rows and cols
        for (int rows = 0; rows < col; rows++)
        {
            for (int cols = row - 1; cols >= 0; cols--)
            {
                Console.Write(matrix[cols,rows] + " ");
            }
            Console.WriteLine();
        }
    }
}
