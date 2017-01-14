using System;

class LocalElections
{
    static void Main()
    {
        int candidates = int.Parse(Console.ReadLine());
        int votingNumber = int.Parse(Console.ReadLine());
        string votingSymbol = Console.ReadLine().ToLower();

        for (int count = 0; count < candidates; count++)
        {
            Console.WriteLine(new string('.', 13));
            Console.WriteLine("...+-----+...");
            if (count + 1 == votingNumber && votingSymbol == "x")
            {
                for (int xCase = 0; xCase <= 2; xCase++)
                {
                    if (xCase == 0)
                    {
                        Console.WriteLine("...|.\\./.|...");
                    }
                    else if (xCase == 1)
                    {
                        Console.WriteLine("{0:D2}.|..{1}..|...", count + 1, votingSymbol.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine("...|./.\\.|...");
                    }
                }
            }
            else if (count + 1 == votingNumber && votingSymbol == "v")
            {
                for (int vCase = 0; vCase <=2; vCase++)
                {
                    if (vCase == 0)
                    {
                        Console.WriteLine("...|\\.../|...");
                    }
                    else if (vCase == 1)
                    {
                        Console.WriteLine("{0:D2}.|.\\./.|...", count + 1);
                    }
                    else
                    {
                        Console.WriteLine("...|..V..|...");
                    }
                }
            }
            else
            {
                for (int normalCase = 0; normalCase <= 2; normalCase++)
                {
                    if (normalCase == 1)
                    {
                        Console.WriteLine("{0:D2}.|.....|...", count + 1);
                    }
                    else
                    {
                        Console.WriteLine("...|.....|...");
                    }
                }
            }
            Console.WriteLine("...+-----+...");
        }
        Console.WriteLine(new string('.', 13));
    }
}
