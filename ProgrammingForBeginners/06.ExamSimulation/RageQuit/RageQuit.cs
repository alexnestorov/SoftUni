using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RageQuit
{
    static void Main()
    {
        string message = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        List<char> uniqueSymbols = new List<char>();

        for (int i = 0; i < message.Length; i++)
        {
            int repeatSymbol = 0;
            // Get number of symbols in each turn.
            int index = 0;
            index = GetNumberOfSymbols(message, i, index);
            string temp = message.Substring(i, index).ToUpper();
            i += index;
            // Calculate repeated symbols.
            if (i + 1 >= message.Length)
            {
                repeatSymbol = int.Parse(message[i].ToString());
            }
            else
            {
                repeatSymbol = ReturnNumberOfRepeatedSymbols(message, ref i);
            }
            if (repeatSymbol > 0)
            {
                AddPhraseToResult(result, repeatSymbol, temp);
                CountUniqueSymbols(uniqueSymbols, temp);
            }
        }
        // Output.
        //uniqueSymbols.Sort();
        Console.WriteLine("Unique symbols used: {0}", uniqueSymbols.Count);
        Console.WriteLine(result);
    }

    static int GetNumberOfSymbols(string message, int i, int index)
    {
        while (!(char.IsDigit(message[i + index])))
        {

            index++;
            if (index == message.Length - 1)
            {
                break;
            }
        }

        return index;
    }

    static int ReturnNumberOfRepeatedSymbols(string message, ref int i)
    {
        int repeatSymbol;
        if (char.IsDigit(message[i + 1]))
        {
            repeatSymbol = 10 * int.Parse(message[i].ToString()) + int.Parse(message[i + 1].ToString());
            i += 1;
        }
        else
        {
            repeatSymbol = int.Parse(message[i].ToString());
        }

        return repeatSymbol;
    }

    static void CountUniqueSymbols(List<char> uniqueSymbols, string temp)
    {
        for (int j = 0; j < temp.Length; j++)
        {
            if (!(uniqueSymbols.Contains(temp[j])))
            {
                uniqueSymbols.Add(temp[j]);
            }
        }
    }

    static void AddPhraseToResult(StringBuilder result, int repeatSymbol, string temp)
    {
        for (int j = 0; j < repeatSymbol; j++)
        {
            result.Append(temp);
        }
    }
}
