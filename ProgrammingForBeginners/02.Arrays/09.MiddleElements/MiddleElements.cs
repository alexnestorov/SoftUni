using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MiddleElements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int leftMiddle = (numbers.Length / 2) - 1;
        int rightMiddle = (numbers.Length / 2) + 1;
        int middle = numbers.Length / 2;
        GetMiddleNumbers(numbers, leftMiddle, rightMiddle, middle);
    }

    static void GetMiddleNumbers(int[] numbers, int leftMiddle, int rightMiddle, int middle)
    {
        if (numbers.Length == 1)
        {
            Console.WriteLine("{0}", numbers[0]);
        }
        else if (numbers.Length % 2 == 0)
        {
            Console.WriteLine("{0}, {1}", numbers[leftMiddle], numbers[middle]);
        }
        else if (numbers.Length % 2 != 0)
        {
            Console.WriteLine("{0}, {1}, {2}", numbers[leftMiddle], numbers[middle], numbers[rightMiddle]);
        }
    }
}
