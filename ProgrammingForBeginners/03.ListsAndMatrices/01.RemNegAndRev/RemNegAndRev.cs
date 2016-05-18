using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemNegAndRev
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] < 0)
            {
                nums.RemoveAt(i);
                i--;
            }
        }
        nums.Reverse();
        if (nums.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
