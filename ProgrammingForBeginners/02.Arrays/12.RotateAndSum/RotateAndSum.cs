using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateAndSum
{
    static void Main()
    {
        // Input variables
        int[] rotate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        int[] temp = new int[rotate.Length];

        // Main Logic. Nested loops in every k turn rotate the numbers into temp array
        for (int i = 0, j = 0; j < k; i++, j ++)
        {
            int index = rotate.Length - 1;
            if (i == rotate.Length) // Reset the rotation to zero.
            {
                i = 0;
            }
            index = SumArrayRotations(rotate, temp, i, index);
        }
        Console.WriteLine(string.Join(" ", temp));
    }

    static int SumArrayRotations(int[] rotate, int[] temp, int i, int index)
    {
        for (int row = 0; row < rotate.Length; row++)
        {
            if (row == i + 1)
            {
                index = 0;

            }
            if (row <= i)
            {
                temp[row] += rotate[index - i];
            }
            else
            {
                temp[row] += rotate[index];
            }
            index++;
        }

        return index;
    }
}
