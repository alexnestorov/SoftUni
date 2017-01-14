using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EmergencyRepairs
{
    static void Main(string[] args)
    {
        int n = 9;
        int s = 5;
        int[] number = { 0, 1, 0, 0, 1 };
        int counter = 0;
        bool isRightBit = true;
        for (int i = 0; i < 29; i++)
        {
            for (int j = 0; j < s; j++)
            {
                if (((n >> j) & 1) == 0)
                {
                    int mask = 1 << j;
                    n = n & mask;
                    isRightBit = true;
                }
                else if (((n >> j) & 1) == 1)
                {
                    int mask = 1 << j;
                    n = n | mask;
                    isRightBit = true;
                    Console.Write(n);
                }
                else
                {
                    isRightBit = false;
                    break;
                }
            }
            if (isRightBit)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
