using System;

class AnimalType
{
    static void Main()
    {
        string animal = Console.ReadLine().ToLower();

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "tortoise":
                Console.WriteLine("reptile");
                break;
            case "crocodile":
                Console.WriteLine("reptile");
                break;
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}
