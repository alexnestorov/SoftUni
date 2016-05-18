using System;

class StupidPasswordGenerator
{
    static void Main(string[] args)
    {
        // Input data 'n' is between 1 to 9. 'L' is length of letters
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        
        // Nested loops for each character of the password.
        // In last loop check if the last digit is greater than the first two digits.
        // If it is true print each result separated by single white space.
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (char k = 'a'; k < ('a' + l); k++)
                {
                    for (char m = 'a'; m < ('a' + l); m++)
                    {
                        for (int z = 0; z <= n; z++)
                        {
                            if (z > i && z > j)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, k, m, z);
                            }
                        }
                    }
                }
            }
        }
    }
}
