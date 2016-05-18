using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class BigFactorial
{
    static void Main()
    {
        int factorialToCalculate = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 2; i <= factorialToCalculate; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
