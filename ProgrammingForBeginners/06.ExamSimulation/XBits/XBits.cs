using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());
            numbers[i] = n;
        }
        int countX = 0;
        for (int i = 0; i < numbers.Length - 2; i++)
        {
            //Console.WriteLine(Convert.ToString(numbers[i],2).PadLeft(32,'0'));
            //Console.WriteLine(Convert.ToString(numbers[i + 1], 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(numbers[i + 2], 2).PadLeft(32, '0'));

            for (int j = 0; j < 32; j++)
            {
                int upX = ((numbers[i] >> j) & 7);
                int middleX = ((numbers[i + 1] >> j) & 7);
                int downX = ((numbers[i + 2] >> j) & 7);
                //Console.WriteLine(Convert.ToString(7, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(upX, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(middleX, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(downX, 2).PadLeft(32, '0'));
                //Console.WriteLine("--------------------------------------------");
                if (upX == 5 && middleX == 2 && downX == 5)
                {
                    countX++;
                }
            }
        }
        Console.WriteLine(countX);
    }
}
