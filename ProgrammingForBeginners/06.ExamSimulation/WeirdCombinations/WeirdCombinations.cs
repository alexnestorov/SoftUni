using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WeirdCombinations
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        int stop = int.Parse(Console.ReadLine());
        int count = -1;
        bool foundStop = count == stop;
        for (int s1 = 0; s1 < sequence.Length; s1++)
        {
            for (int s2 = 0; s2 < sequence.Length; s2++)
            {
                for (int s3 = 0; s3 < sequence.Length; s3++)
                {
                    for (int s4 = 0; s4 < sequence.Length; s4++)
                    {
                        for (int s5 = 0; s5 < sequence.Length; s5++)
                        {
                            count++;
                            if (count == stop)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}", sequence[s1]
                                                                   , sequence[s2]
                                                                   , sequence[s3]
                                                                   , sequence[s4]
                                                                   , sequence[s5]);
                                foundStop = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
        if (!foundStop)
        {
            Console.WriteLine("No");
        }
    }
}
