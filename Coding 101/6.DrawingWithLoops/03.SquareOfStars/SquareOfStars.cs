using System;

class SquareOfStars
{
    static void Main()
    {
        int stars = int.Parse(Console.ReadLine());
        string star = "* ";
        for (int rows = 0; rows < stars; rows++)
        {
            for (int cols = 0; cols < stars; cols++)
            {
                Console.Write("{0}", star);
            }
            Console.WriteLine();
        }
    }
}
