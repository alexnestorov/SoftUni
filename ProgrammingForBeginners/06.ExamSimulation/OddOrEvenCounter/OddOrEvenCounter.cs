using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOrEvenCounter
{
    static void Main()
    {
        int setsCount = int.Parse(Console.ReadLine());
        int numbersInSet = int.Parse(Console.ReadLine());
        string search = Console.ReadLine().ToLower();
        int start = -1;
        if (search == "odd")
        {
            start = 1;
        }
        else
        {
            start = 0;
        }
        string[] wordSet = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        int maxCount = int.MinValue;
        int maxSet = int.MinValue;
        int count = 0;
        for (int i = 0; i < setsCount; i++)
        {
            for (int j = 0; j < numbersInSet; j++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == start)
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxSet = i;
            }
            count = 0;
        }
            
        if (maxCount > 0)
        {
            Console.WriteLine("{0} set has the most {2} numbers: {1}", wordSet[maxSet]
                                                                     , maxCount
                                                                     , search);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
