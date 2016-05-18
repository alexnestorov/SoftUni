using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] num = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            num[i] = true;
        }
        for (int i = 2; i <= n; i++)
        {
            if (num[i])
            {
                Console.WriteLine(i);
                int p = 2 * i;
                while (p <= n)
                {
                    num[p] = false;
                    p = p + i;
                }
            }
        }
    }
}
