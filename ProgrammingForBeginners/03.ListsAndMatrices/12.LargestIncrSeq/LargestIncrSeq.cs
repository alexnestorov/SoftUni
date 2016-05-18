using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestIncrSeq
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] size = new int[numbers.Count];
        string[] path = new string[numbers.Count];
        for (int i = 0; i < numbers.Count; i++)
        {
            size[i] = 1;
            path[i] = numbers[i] + " ";
        }
        int max = 1;

        for (int i = 1; i < numbers.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] > numbers[j] && size[i] < size[j] + 1)
                {
                    size[i] = size[j] + 1;
                    path[i] = path[j] + numbers[i] + " ";
                    if (max < size[i])
                    {
                        max = size[i];
                    }
                }
            }
        }
        Console.WriteLine(max);
        //if (max == 1)
        //{
        //    Console.WriteLine(numbers[0]);
        //}
        //else
        //{
        //    for (int i = 1; i < numbers.Count; i++)
        //    {
        //        if (size[i] == max)
        //        {
        //            Console.Write(path[i] + " ");
        //            return;
        //        }
        //    }
        //}
    }
}
