using System;

class Rectangle10by10
{
    static void Main()
    {
        int stars = 10;
        for (int i = 0; i < stars; i++)
        {
            Console.WriteLine(new string('*', stars));
        }
    }
}
