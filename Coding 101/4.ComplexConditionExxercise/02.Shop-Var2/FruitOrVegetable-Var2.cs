using System;

class FruitOrVegetableVar2
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine().ToLower();

        string[] fruit = new string[] { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
        string[] vegetable = new string[] { "tomato", "cucumber", "pepper", "carrot" };

        if (product == fruit[0] || product == fruit[1] || product == fruit[2] || product == fruit[3]
                || product == fruit[4] || product == fruit[5])
        {
            Console.WriteLine("fruit");
        }
        else if (product == vegetable[0] || product == vegetable[1] || product == vegetable[2] || product == vegetable[3])
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
