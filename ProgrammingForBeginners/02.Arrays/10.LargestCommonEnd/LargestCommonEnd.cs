using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestCommonEnd
{
    static void Main()
    {
        string[] words1 = Console.ReadLine().Split(' ').ToArray();
        string[] words2 = Console.ReadLine().Split(' ').ToArray();
        int counter = Math.Min(words1.Length, words2.Length);
        int left = 0;
        int right = 0;

        left = LeftCountCommonEnd(words1, words2, counter, left);
        right = RightCountCommonEnd(words1, words2, counter, right);

        FinalResult(left, right);

    }

    static void FinalResult(int left, int right)
    {
        if (left >= right)
        {
            Console.WriteLine(left);
        }
        else if (right > left)
        {
            Console.WriteLine(right);
        }
        else
        {
            Console.WriteLine(0);
        }
    }

    static int RightCountCommonEnd(string[] words1, string[] words2, int counter, int right)
    {
        for (int i = 1; i <= counter; i++)
        {
            if (words1[words1.Length - i] == words2[words2.Length - i])
            {
                right++;
            }
        }

        return right;
    }

    static int LeftCountCommonEnd(string[] words1, string[] words2, int counter, int left)
    {
        for (int i = 0; i < counter; i++)
        {
            if (words1[i] == words2[i])
            {
                left++;
            }
        }

        return left;
    }
}
