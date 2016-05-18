using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FoldAndSum
{
    static void Main()
    {
        int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int m = 0;
        int b = 0;

        int[] upper = new int[arrOne.Length / 4];
        int[] bottom = new int[arrOne.Length / 4];
        int[] middle = new int[arrOne.Length / 2];

        FillSeparatedArrays(arrOne, ref m, ref b, upper, bottom, middle);

        b = 0; // Reset index of bottom array
        int[] result = ConcatanateArrays(arrOne, ref b, upper, bottom, middle);
        Console.WriteLine(string.Join(" ", result));
    }

    static int[] ConcatanateArrays(int[] arrOne, ref int b, int[] upper, int[] bottom, int[] middle)
    {
        int[] result = new int[arrOne.Length / 2];
        for (int i = 0; i < arrOne.Length / 4; i++)
        {
            result[i] = upper[i] + middle[i];
        }
        for (int i = arrOne.Length / 4; i < arrOne.Length / 2; i++)
        {
            result[i] = middle[i] + bottom[bottom.Length - b - 1];
            b++;
        }

        return result;
    }

    static void FillSeparatedArrays(int[] arrOne, ref int m, ref int b, int[] upper, int[] bottom, int[] middle)
    {
        for (int i = 0; i < arrOne.Length; i++)
        {
            if (i < arrOne.Length / 4)
            {
                upper[i] = arrOne[arrOne.Length / 4 - i - 1];
            }
            else if (i >= arrOne.Length / 4 && i < arrOne.Length - arrOne.Length / 4)
            {
                middle[m] = arrOne[i];
                m++;
            }
            else if (i >= arrOne.Length - arrOne.Length / 4)
            {
                bottom[b] = arrOne[i];
                b++;
            }
        }
    }
}
