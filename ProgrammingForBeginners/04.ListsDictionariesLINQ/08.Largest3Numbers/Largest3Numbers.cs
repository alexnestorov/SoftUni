using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Largest3Numbers
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        List<int> numbers = nums.Select(int.Parse).ToList();
        // Using Lambda function to order numbers in descending order
        IEnumerable<int> result = numbers.OrderBy(x => -x);
        // Using Linq to take the first three ordered numbers.
        IEnumerable<int> largest = result.Take(3); 
        Console.WriteLine(string.Join(" ", largest));
    }
}
