using System;

class NumberPyramid
{
    static void Main()
    {
        int pyramidNumber = int.Parse(Console.ReadLine());
        int number = 0;

        for (int cols = 0; cols < pyramidNumber; cols++)
        {
            for (int rows = 0; rows <= cols; rows++)
            {
                number++;
                if (number > pyramidNumber)
                {
                    return;
                }
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
