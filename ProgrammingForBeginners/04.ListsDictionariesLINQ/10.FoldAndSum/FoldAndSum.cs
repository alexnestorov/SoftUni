using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FoldAndSum
{
    static void Main()
    {
        int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = numArray.Length / 4;
        // Using Lambda function to take first k elements and then reverse order.
        IEnumerable<int> rowLeft = numArray.Take(k).Reverse();
        // Using Lambda function to take last k elements.
        IEnumerable<int> rowRight = numArray.Reverse().Take(k);
        // Concat two enumerables in array.
        int[] first = rowLeft.Concat(rowRight).ToArray();
        // Using Lambda function to take the middle part of numArray which has exactly 2 * k members.
        int[] middle = numArray.Skip(k).Take(2 * k).ToArray();
        // Using Lambda function to sum each position of the two arrays.
        IEnumerable<int> result = first.Select((x, index) => x + middle[index]);
        Console.WriteLine(string.Join(" ", result));
    }
}
