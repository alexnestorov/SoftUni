using System;

class FruitVegetable
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        //string[] fruit = new string[] {"banana", "apple", "kiwi", "lemon", "grapes"};
        //string[] vegetable = new string[] {"tomato", "cucumber", "pepper", "carrot"};
        //bool compare = product =
        if (product == "banana" || product == "apple" || product == "kiwi" || product == "lemon" || product == "grapes" || product == "cherry")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else Console.WriteLine("unknown");
    }
}
