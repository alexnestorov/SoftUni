using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitLock
{
    static void Main()
    {
        int[] colNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //for (int i = 0; i < colNumbers.Length; i++)
        //{
        //    Console.WriteLine(Convert.ToString(colNumbers[i], 2).ToString().PadLeft(11,'0'));
        //}
        //int[,] matrix = new int[row, colNumbers.Length];

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] orders = command.Split(' ');
            if (command.Contains("check"))
            {
                int countOneBits = 0;
                int position = int.Parse(orders[1]);
                foreach (var number in colNumbers)
                {

                    int bit = (number >> position) & 1;
                    if (bit == 1)
                    {
                        countOneBits++;
                    }
                }
                Console.WriteLine(countOneBits);
            }
            else if (command.Contains("right"))
            {
                int rowPosition = int.Parse(orders[0]);
                int rotations = int.Parse(orders[2]);
                for (int i = 0; i < rotations; i++)
                {
                    int bit = colNumbers[rowPosition] & 1;
                    colNumbers[rowPosition] >>= 1;
                    colNumbers[rowPosition] |= bit << 11;
                }

            }
            else if (command.Contains("left"))
            {
                int rowPosition = int.Parse(orders[0]);
                int rotations = int.Parse(orders[2]);
                for (int i = 0; i < rotations % 12; i++)
                {
                    int bit = colNumbers[rowPosition] >> 11 & 1;
                    colNumbers[rowPosition] &= ~(1 << 11);
                    colNumbers[rowPosition] <<= 1;
                    colNumbers[rowPosition] |= bit;
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", colNumbers));
    }
}
