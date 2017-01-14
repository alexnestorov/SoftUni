using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMatcher
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] arr = inputLine.Split('\\');
        string firstArr = arr[0];
        string secondArr = arr[1];
        List<char> result = new List<char>();

        for (int count = 0; count < firstArr.Length; count++)
        {
            if (inputLine.EndsWith("join"))
            {
                if (secondArr.Contains(firstArr[count]))
                {
                    result.Add(firstArr[count]);
                }
            }
            else if (inputLine.EndsWith("right exclude"))
            {
                if (!(secondArr.Contains(firstArr[count])))
                {
                    result.Add(firstArr[count]);
                }
            }
        }
        for (int i = 0; i < secondArr.Length; i++)
        {
            if (inputLine.EndsWith("left exclude"))
            {
                if (!(firstArr.Contains(secondArr[i])))
                {
                    result.Add(secondArr[i]);
                }
            }
        }
        result.Sort();
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }

    }
}
