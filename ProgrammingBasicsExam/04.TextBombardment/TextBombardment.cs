using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextBombardment
{
    static void Main()
    {
        string bombMessage = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<string> result = new List<string>();

        for (int i = 0; i < bombMessage.Length; i++)
        {
            bool isInBombPosition = false;
            for (int col = 0; col < columns.Length; col++)
            {
                int checkerIndex = i % width;
                
                if (checkerIndex == columns[col])
                {
                    if (bombMessage[i] == ' ' && i > width)
                    {
                        columns[col] = -1;
                    }
                    else
                    {
                        isInBombPosition = true;
                        break;
                    }
                }
            }
            if (isInBombPosition == true)
            {
                result.Add(" ");
            }
            else if (isInBombPosition == false)
            {
                result.Add(bombMessage[i].ToString());
            }
        }
        Console.WriteLine(string.Join("", result));
    }
}
