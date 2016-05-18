using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfLetters
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col= int.Parse(Console.ReadLine());
        char[,] matrix = new char[row, col];
        char letter = 'A';
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = letter;

                if (letter == 'Z')
                {
                    letter = '@';
                }
                letter++;
                Console.Write("{0} ", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}
