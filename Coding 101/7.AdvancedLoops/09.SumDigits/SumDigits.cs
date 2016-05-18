using System;

class SumDigits
{
    static void Main()
    {
        //int number = int.Parse(Console.ReadLine());
        //int result = 0;
        //for (int count = number; count > 0; count /= 10)
        //{
        //    result += count % 10;
        //}
        //Console.WriteLine(result);
        string number = "5634"; //Console.ReadLine();
        int result = 0;
        int[] arr = new int[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            arr[i] = int.Parse(number[i].ToString());
            result += arr[i];
        }
        Console.WriteLine(result);
    }
}
