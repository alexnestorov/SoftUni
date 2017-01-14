using System;

class SaltAndPepper
{
    static void Main()
    {
        ulong bitNumber = ulong.Parse(Console.ReadLine());
        string command = Console.ReadLine().ToLower();
        while (command != "end")
        {
            string[] commElem = command.Split(' ');
            string word = commElem[0];
            int bitStep = int.Parse(commElem[1]);
            if (word == "salt")
            {
                for (int i = 0; i < 64; i += bitStep)
                {
                    if (((bitNumber >> i) & 1) == 1)
                    {
                        ulong mask = ~((ulong)1 << i);
                        bitNumber = bitNumber & mask;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 64; i += bitStep)
                {
                    if ((bitNumber >> i & 1) == 0)
                    {
                        ulong mask = ((ulong)1 << i);
                        bitNumber = mask | bitNumber;
                    }
                }
            }
            command = Console.ReadLine().ToLower();
        }
        Console.WriteLine(bitNumber);
    }
}
