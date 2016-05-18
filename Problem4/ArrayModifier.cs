using System;
using System.Linq;

class ArrayModifier
{
    static void Main()
    {
        long[] arrayNums = Console.ReadLine().Split(' ')
                                             .Select(long.Parse)
                                             .ToArray();

        //Console.WriteLine(string.Join(" ", arrayNums));

        string input = Console.ReadLine().ToLower();

        while (input != "end")
        {
            string[] commands = input.Split(' ');
            string order = commands[0];

            // Decrease all elements with 1.
            if (order == "decrease")
            {
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    arrayNums[i]--;
                }
            }
            else
            {
                int first = int.Parse(commands[1].ToString());
                int second = int.Parse(commands[2].ToString());
                
                // Swap elements by read indexes.
                if (order == "swap")
                {
                    long temp = arrayNums[first];
                    arrayNums[first] = arrayNums[second];
                    arrayNums[second] = temp;
                }
                // Muliply element at first index with the element of second index.
                else if (order == "multiply")
                {
                    arrayNums[first] *= arrayNums[second];
                }
            }
            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", arrayNums));
    }
}
