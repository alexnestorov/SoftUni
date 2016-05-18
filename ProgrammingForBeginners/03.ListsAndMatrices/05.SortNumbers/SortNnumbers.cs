using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortNnumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        numbers.Sort();
        Console.WriteLine(string.Join(" ", numbers));
    }
}
