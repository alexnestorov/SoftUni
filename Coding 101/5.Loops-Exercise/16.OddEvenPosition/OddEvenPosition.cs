using System;

class OddEvenPosition
{
    static void Main()
    {
        // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        double oddSumResult = 0;
        double evenSumResult = 0;
        double minNumberOdd = double.MaxValue;
        double maxNumberOdd = double.MinValue;
        double minNumberEven = double.MaxValue;
        double maxNumberEven = double.MinValue;

        // Main Logic
        for (int sequence = 1; sequence <= numbersToEnter; sequence++)
        {
            double sumNumbers = double.Parse(Console.ReadLine());
            // Check for Odd numbers
            if (sequence % 2 != 0)
            {
                oddSumResult += sumNumbers;
                if (sumNumbers > maxNumberOdd)
                {
                    maxNumberOdd = sumNumbers;
                }
                if (sumNumbers < minNumberOdd)
                {
                    minNumberOdd = sumNumbers;
                }
            }
            // Check for Even numbers
            else if (sequence % 2 == 0)
            {
                evenSumResult += sumNumbers;
                if (sumNumbers > maxNumberEven)
                {
                    maxNumberEven = sumNumbers;
                }
                if (sumNumbers < minNumberEven)
                {
                    minNumberEven = sumNumbers;
                }
            }
        }
        // Output
        Console.WriteLine("OddSum={0}", oddSumResult);
        if (minNumberOdd == double.MaxValue && maxNumberOdd == double.MinValue)
        {
            Console.WriteLine("OddMin=No");
            Console.WriteLine("OddMax=No");
        }
        else
        {
            Console.WriteLine("OddMin={0}", minNumberOdd);
            Console.WriteLine("OddMax={0}", maxNumberOdd);
        }
        Console.WriteLine("EvenSum={0}", evenSumResult);
        if (minNumberEven == double.MaxValue && maxNumberEven == double.MinValue)
        {
            Console.WriteLine("EvenMin=No");
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine("EvenMin={0}", minNumberEven);
            Console.WriteLine("EvenMax={0}", maxNumberEven);
        }
    }
}
