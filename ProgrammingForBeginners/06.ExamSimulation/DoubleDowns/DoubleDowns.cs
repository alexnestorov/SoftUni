using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayN = new int[n];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            arrayN[i] = number;
        }
        int verticalCounts = 0;
        int rightDiagonal = 0;
        int leftDiagonal = 0;
        for (int i = 1; i < n; i++)
        {
            int temp1 = arrayN[i - 1];
            int temp2 = arrayN[i];
            for (int j = 0; j < 32; j++)
            {
                int vert1 = (temp1 >> j) & 1;
                int vert2 = (temp2 >> j) & 1;
                int left1 = (temp1 >> j) & 1;
                int left2 = (temp2 >> j + 1) & 1;
                int right1 = (temp1 >> 32 - j) & 1;
                int right2 = (temp2 >> 32 - j - 1) & 1;
                if (vert1 == 1 && vert2 == 1)
                {
                    verticalCounts++;
                }
                if (left1 == 1 && left2 == 1)
                {
                    leftDiagonal++;
                }
                if (right1 == 1 && right2 == 1)
                {
                    rightDiagonal++;
                }
            }
        }
        //Output.
        Console.WriteLine(rightDiagonal);
        Console.WriteLine(leftDiagonal);
        Console.WriteLine(verticalCounts);
    }
}
