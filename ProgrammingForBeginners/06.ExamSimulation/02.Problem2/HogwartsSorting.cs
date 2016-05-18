using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> facultyNumber = new List<string>();
        string[] faculties = { "Gryffindor", "Slytherin", "Ravenclaw", "Hufflepuff" };
        int countG = 0;
        int countS = 0;
        int countR = 0;
        int countH = 0;
        for (int i = 0; i < n; i++)
        {
            string[] newComers = Console.ReadLine().Split(' ').ToArray();
            string firstName = newComers[0];
            string lastName = newComers[1];
            int result = 0;
            string facultyRes = "";
            for (int j = 0; j < firstName.Length; j++)
            {
                int currentSymbol = firstName[j];
                result += currentSymbol;
            }
            for (int j = 0; j < lastName.Length; j++)
            {
                int currentSymbol = lastName[j];
                result += currentSymbol;
            }
       
            if (result % 4 == 0)
            {
                facultyRes = faculties[0] + " " + result.ToString() + (char)firstName[0] + (char)lastName[0];
                countG++;
            }
            else if (result % 4 == 1)
            {
                facultyRes = faculties[1] + " " +result.ToString() + (char)firstName[0] + (char)lastName[0];
                countS++;
            }
            else if (result % 4 == 2)
            {
                facultyRes = faculties[2] + " " + result.ToString() + (char)firstName[0] + (char)lastName[0];

                countR++;
            }
            else if (result % 4 == 3)
            {
                facultyRes = faculties[3] + " "+ result.ToString() + (char)firstName[0] + (char)lastName[0];

                countH++;
            }
            facultyNumber.Add(facultyRes);
            result = 0;
        }
        foreach (var item in facultyNumber)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("{0}: {1}", faculties[0], countG);
        Console.WriteLine("{0}: {1}", faculties[1], countS);
        Console.WriteLine("{0}: {1}", faculties[2], countR);
        Console.WriteLine("{0}: {1}", faculties[3], countH);

    }
}
