using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestFrameInMatrix
{
    static void Main()
    {
        // TO DO THE TASk
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int row = input[0];
        int col = input[1];
        int max = row * col;
        int[,] matrix = new int[row, col];
        string[] numbersInMatrix;
        for (int r = 0; r < row; r++)
        {
            numbersInMatrix = Console.ReadLine().Split(' ').ToArray();
            for (int c = 0; c < col; c++)
            {
                matrix[r, c] = (int.Parse)(numbersInMatrix[c]);
            }
        }
        int count = 0;
        string direction = "right";
        int r1 = 0;
        int c1 = 0;
        int[,] start = new int[0, 0];
        for (int i = 0; i < row; i++)
        {
            if (matrix[r1, c1] != matrix[r1 + 1, c1 + 1] && c1 < col - 1 && direction == "right")
            {
                int highCol = c1;
                c1--;
                r1++;
                direction = "down";
            }
            else if (matrix[r1, c1] != matrix[r1 + 1, c1 + 1] && r1 < row - 1 && direction == "down")
            {
                int highRow = r1;
                c1--;
                r1++;
                direction = "left";
            }
            else if (matrix[r1, c1] != matrix[r1 + 1, c1 + 1] && c1 > 0 && direction == "left")
            {
                int lowCol = c1;
                c1--;
                r1++;
                direction = "up";
            }
            else if (matrix[r1, c1] != matrix[r1 + 1, c1 + 1] && r1 > 0 && direction == "up")
            {
                int lowRow = r1;
                c1--;
                r1++;
                direction = "right";
            }
            
            if (direction == "right")
            {
                c1++;
            }
            else if (direction == "down")
            {
                r1++;
            }
            else if (direction == "left")
            {
                c1--;
            }
            else if (direction == "up")
            {
                r1--;
            }
            Console.WriteLine("{0}X{1}", r1 + 1, c1 + 1);
        }
    }
    // Print matrix
    //for (int r = 0; r < row; r++)
    //{
    //    for (int c = 0; c < col; c++)
    //    {
    //        Console.Write(matrix[r,c] + " ");
    //    }
    //    Console.WriteLine();
    //}
}
