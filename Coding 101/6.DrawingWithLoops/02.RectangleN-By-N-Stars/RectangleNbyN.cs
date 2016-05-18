using System;

class RectangleNbyN
{
    static void Main()
    {
        int stars = int.Parse(Console.ReadLine());
        for (int i = 0; i < stars; i++)
        {
            Console.WriteLine(new string('*', stars));
        }
    }
}
