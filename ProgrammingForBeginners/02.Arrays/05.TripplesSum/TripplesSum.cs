using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TripplesSum
{
    static void Main()
    {
        int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isResult = false;
        for (int i = 0; i < arrNums.Length; i++)
        {
            for (int j = i + 1; j < arrNums.Length; j++)
            {
                int sum = arrNums[i] + arrNums[j];
                if (arrNums.Contains(sum))
                {
                    isResult = true;
                    Console.WriteLine("{0} + {1} == {2}", arrNums[i], arrNums[j], sum);
                }
            }
        }
        if (isResult == false)
        {
            Console.WriteLine("No");
        }
    }
}
