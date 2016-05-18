using System;

class EqualPairs
{
    static void Main()
    {
        int numbersToEnter = int.Parse(Console.ReadLine());
        int oddNumbers = int.Parse(Console.ReadLine());
        int evenNumbers = int.Parse(Console.ReadLine());
        int sumFirstPair = oddNumbers + evenNumbers;
        int previousPairSum = 0;
        int currentPairSum = 0;
        int check = int.MinValue;
        if (numbersToEnter > 1)
        {
            for (int sequence = 1; sequence < numbersToEnter; sequence++)
            {
                previousPairSum = oddNumbers + evenNumbers;
                oddNumbers = int.Parse(Console.ReadLine());
                evenNumbers = int.Parse(Console.ReadLine());
                currentPairSum = oddNumbers + evenNumbers;
                if (check < Math.Abs(previousPairSum - currentPairSum))
                {
                    check = Math.Abs(previousPairSum - currentPairSum);
                }
            }
        }
        if (numbersToEnter == 1)
        {
            Console.WriteLine("Yes, value={0}", sumFirstPair);
        }
        else if (check == 0)
        {
            Console.WriteLine("Yes, value={0}",sumFirstPair);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", Math.Abs(check));
        }
    }
}

