using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSeqEqualNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int seqNum = int.MinValue;
        int count = 1;
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (max < count)
            {
                max = count;
                seqNum = numbers[i];
            }
        }
        for (int i = 0; i < max; i++)
        {
            Console.Write("{0} ",seqNum);
        }
    }
}
