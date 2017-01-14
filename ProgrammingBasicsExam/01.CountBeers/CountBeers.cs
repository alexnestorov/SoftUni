using System;

class CountBeers
{
    static void Main()
    {
        string inputLine = Console.ReadLine().ToLower();
        int beers = 0;

        while (inputLine != "end")
        {
            string[] dataInput = inputLine.Split(' ');
            int numberBeers = int.Parse(dataInput[0].ToString());
            if (inputLine.EndsWith("stacks"))
            {
                beers += numberBeers * 20;
            }
            else if (inputLine.EndsWith("beers"))
            {
                beers += numberBeers;
            }
            inputLine = Console.ReadLine().ToLower();
        }

        Console.WriteLine("{0} stacks + {1} beers"
            , beers / 20
            , beers % 20);
    }
}
