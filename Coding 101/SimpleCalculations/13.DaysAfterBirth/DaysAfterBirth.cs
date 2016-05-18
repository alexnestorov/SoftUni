using System;
using System.Globalization;

class DaysAfterBirth
{

    static void Main()
    {
        string format = "dd-MM-yyyy";
        string dateofBirth = Console.ReadLine();
        DateTime birth = DateTime.ParseExact(dateofBirth, format, null);
        Console.WriteLine(birth.AddDays(999).ToString(format));
        //DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        //DateTime answer = dateOfBirth.AddDays(1000);
        //Console.WriteLine("{0:dd-MM-yyyy}",answer);
    }
}
