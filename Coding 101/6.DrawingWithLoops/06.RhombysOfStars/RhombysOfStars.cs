using System;

class RhombysOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string star = "* ";
        for (int firstPart = 0; firstPart < n; firstPart++)
        {
            Console.Write(new string(' ', n - firstPart - 1));
            for (int i = 0; i <= firstPart; i++)
            {
                Console.Write("{0}", star);
            }
            Console.WriteLine();
        }
        for (int secondPart = 0; secondPart < n - 1; secondPart++)
        {
            Console.Write(new string(' ', secondPart + 1));
            for (int i = n - secondPart - 1; i > 0; i--)
            {
                Console.Write("{0}", star);
            }
            Console.WriteLine();
        }
    }
}
