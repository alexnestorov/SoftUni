using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int row = numbers[0];
        int col = numbers[1];
        string[,] matrix = new string[row, col];
        char firstLetter = 'a';
        char secondLetter = 'a';
        char thirdLetter = 'a';

        for (int r = 0; r < row; r++)
        {
            firstLetter = (char)('a' + r % 26);
            thirdLetter = (char)('a' + r % 26);
            for (int c = 0; c < col; c++)
            {
                secondLetter = (char)('a'+ (c + r)%26);
                matrix[r, c] = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString();
                Console.Write("{0} ",matrix[r,c]);
            }
            Console.WriteLine();
            
        }
    }
}
