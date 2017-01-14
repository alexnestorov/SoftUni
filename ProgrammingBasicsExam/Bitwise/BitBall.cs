using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    class BitBall
    {
        static void Main(string[] args)
        {
            int len = 8;
            int[,] matrix = new int[len, len];

            // Get players A team
            for (int i = 0; i < len; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 0; j < len; j++)
                {
                    int bit = ((num >> j) & 1);
                    if (bit == 1)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            // Get players B team
            for (int i = 0; i < len; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 0; j < len; j++)
                {
                    int bit = ((num >> j) & 1);
                    if (bit == 1)
                    {
                        if (matrix[i, j] == 1)
                        {
                            matrix[i, j] = 0;
                        }
                        else
                        {
                            matrix[i, j] = 2;
                        }
                    }
                }
            }
            int cntA = 0;
            int cntB = 0;
            // Goal scored for B team
            for (int cols = 0; cols < len; cols++)
            {
                for (int rows = 0; rows < len; rows++)
                {
                    if (matrix[rows, cols] == 1)
                    {
                        break;
                    }
                    else if (matrix[rows, cols] == 2)
                    {
                        cntB++;
                        break;
                    }
                }
            }
            // Goal scored for A team
            for (int cols = 0; cols < len; cols++)
            {
                for (int rows = len - 1; rows >= 0; rows--)
                {
                    if (matrix[rows, cols] == 2)
                    {
                        break;
                    }
                    else if (matrix[rows, cols] == 1)
                    {
                        cntA++;
                        break;
                    }
                }
            }
            Console.WriteLine("{0}:{1}", cntA, cntB);
        }
    }
}
