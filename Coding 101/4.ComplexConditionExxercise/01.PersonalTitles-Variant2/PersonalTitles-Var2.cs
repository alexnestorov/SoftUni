using System;

class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine().ToLower());

        if (gender == 'm')
        {
            if (age >= 16) Console.WriteLine("Mr.");
            else if (age < 16) Console.WriteLine("Master");
        }
        else if (gender == 'f')
        {
            if (age >= 16) Console.WriteLine("Ms.");
            else if (age < 16) Console.WriteLine("Miss");
        }
    }
}
