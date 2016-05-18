using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CondenseNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        while (numbers.Length > 1)
        {
            int[] result = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result[i] = numbers[i] + numbers[i + 1];
            }
            numbers = result;
        }
        Console.WriteLine(numbers[0]);
    }
}
