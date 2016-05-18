using System;

class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine().ToLower());

        if (gender == 'm' && age >= 16)
        {
            Console.WriteLine("Mr.");
        }
        else if (gender == 'm' && age < 16)
        {
            Console.WriteLine("Master");
        }
        else if (gender == 'f' && age >= 16)
        {
            Console.WriteLine("Ms.");
        }
        else if (gender == 'f' && age < 16)
        {
            Console.WriteLine("Miss");
        }
    }
}
