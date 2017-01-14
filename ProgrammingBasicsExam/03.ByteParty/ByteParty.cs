using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ByteParty
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            array[i] = number;
        }
        string[] command = Console.ReadLine().Split(' ').ToArray();
        
        while (command[0] != "party" && command[1] != "over")
        {
            int bitPosition = int.Parse(command[1]);
            for (int i = 0; i < array.Length; i++)
            {
                if (command[0] == "-1")
                {
                    array[i] = array[i] ^ (1 << bitPosition); // Formula flip bit.
                }
                else if (command[0] == "0")
                {
                    array[i] = array[i] & ~(1 << bitPosition); // Formula unset bit.
                }
                else if (command[0] == "1")
                {
                    array[i] = array[i] | (1 << bitPosition); // Formula set bit.
                }
            }
            command = Console.ReadLine().Split(' ').ToArray();
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
