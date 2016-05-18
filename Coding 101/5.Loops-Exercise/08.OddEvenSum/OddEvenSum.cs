using System;

class OddEvenSum
{
    static void Main()
    {
        // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int oddSumResult = 0;
        int evenSumResult = 0;

        // Main Logic
        for (int sequence = 1; sequence <= numbersToEnter; sequence++)
        {
            int sumNumbers = int.Parse(Console.ReadLine());
            if (sequence % 2 == 0)
            {
                oddSumResult += sumNumbers;
            }
            else if (sequence % 2 != 0)
            {
                evenSumResult += sumNumbers;
            }
        }
        // Output 
        if (oddSumResult != evenSumResult)
        {
            Console.WriteLine("No \nDiff = {0}", Math.Abs(oddSumResult - evenSumResult));
        }
        else
        {
            Console.WriteLine("Yes \nSum = {0}", (oddSumResult + evenSumResult) / 2);
        }
    }
}
