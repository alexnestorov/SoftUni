using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountRealNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        SortedDictionary<double, int> nums = new SortedDictionary<double, int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (nums.ContainsKey(numbers[i]))
            {
                nums[numbers[i]]++;
            }
            else
            {
                nums[numbers[i]] = 1;
            }
        }
        foreach (var num in nums.Keys)
        {
            Console.WriteLine("{0} -> {1} times", num, nums[num]);
        }

    }
}
