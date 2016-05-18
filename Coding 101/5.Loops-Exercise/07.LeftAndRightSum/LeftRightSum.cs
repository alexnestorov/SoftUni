using System;

class LeftRightSum
{
    static void Main()
    {
            // Input variables
        int numbersToEnter = int.Parse(Console.ReadLine());
        int leftSumResult = 0;
        int rightSumResult = 0;

            // Main Logic
        for (int sequence = 1; sequence <= 2*numbersToEnter; sequence++)
        {
            if (sequence <= numbersToEnter)
            {
                int leftSumNumbers = int.Parse(Console.ReadLine());
                leftSumResult += leftSumNumbers;
            }
            else if (sequence > numbersToEnter)
            {
                int rightSumNumbers = int.Parse(Console.ReadLine());
                rightSumResult += rightSumNumbers;
            }
        }

            // Output 
        if (leftSumResult != rightSumResult)
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSumResult - rightSumResult));
        }
        else
        {
            Console.WriteLine("Yes, sum = {0}", (leftSumResult + rightSumResult) / 2);
        }
    }
}
