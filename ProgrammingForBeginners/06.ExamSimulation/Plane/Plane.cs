using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 3 * n;
        int height = (3 * n) - (n / 2);

        Console.WriteLine("{0}*{0}", new string('.', width / 2));
        for (int i = 0; i < (n / 2) + 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', width / 2 - i - 1 )
                                           , new string('.', 2 * i + 1));
        }
        for (int i = 1; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.', n - 2 - 2 * i)
                                           , new string('.', width + 2 - 2 * n + 4 * i));
        }
        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2 - 2 * i)
                                                 , new string('.', n));

            }
            else
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', n - 2 - 2 * i)
                                                         , new string('.', 2 * i - 1)
                                                         , new string('.', n));

            }
        }
        for (int i = 0; i < n - 1 ; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - i - 1)
                                           , new string('.', n + 2 * i));
        }
        Console.WriteLine("{0}", new string('*',width));
    }
}
