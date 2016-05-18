using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumArrays
{
    static void Main()
    {
        int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int high = Math.Max(arrTwo.Length, arrOne.Length);
        int index1 = 0;
        int index2 = 0;
        int[] sum = new int[high];
        for (int i = 0; i < high; i++)
        {
            sum[i] = arrOne[index1] + arrTwo[index2];
            index1++;
            index2++;
            ResetSmallerArrayCount(arrOne, arrTwo, ref index1, ref index2); // Reset index if arrays length are not equal
        }
        Console.WriteLine(string.Join(" ", sum));
    }

    static void ResetSmallerArrayCount(int[] arrOne, int[] arrTwo, ref int index1, ref int index2)
    {
        if (arrOne.Length > arrTwo.Length && index2 == arrTwo.Length)
        {
            index2 = 0;
        }
        else if (arrOne.Length <= arrTwo.Length && index1 == arrOne.Length)
        {
            index1 = 0;
        }
    }
}
