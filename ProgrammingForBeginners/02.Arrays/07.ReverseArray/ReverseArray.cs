using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseArray
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < nums.Length / 2; i++)
        {
            int prev = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - 1 - i] = prev;
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
