using System;

class Increasing4Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        if (b - a >= 3)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = a + 1; j <= b; j++)
                {
                    for (int k = a + 2; k <= b; k++)
                    {
                        for (int l = a + 3; l <= b; l++)
                        {
                            if (i < j && j < k && k < l)
                            {
                                Console.WriteLine("{0} {1} {2} {3} ", i, j, k, l);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
