using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChessQueens
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int row = n;
        int col = n;
        for (char r = 'a'; r < 'a' + row; r++)
        {
            for (int c = 1; c <= col; c++)
            {
                if (c % (distance + 1) == 0)
                {
                    Console.WriteLine("{0}{1}", r, c);
                }
            }
        }
    }
}
