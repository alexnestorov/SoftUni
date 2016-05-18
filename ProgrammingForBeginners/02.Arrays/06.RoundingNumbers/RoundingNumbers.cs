using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RoundingNumbers
{
    static void Main()
    {
        double[] rounding = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < rounding.Length; i++)
        {
            int round = (int) Math.Round(rounding[i], MidpointRounding.AwayFromZero);
            Console.WriteLine("{0} => {1}", rounding[i], round);
        }
    }
}
