using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        var mobilePhone = new Dictionary<string, string>();
        string input = Console.ReadLine();
        while ((input!="search"))
        {
            string[] phoneData = input.Split('+', '-')
                                      .ToArray();
            if (mobilePhone.ContainsKey(phoneData[0]))
            {
                mobilePhone[phoneData[0]] = phoneData[1];
            }
            else
            {
                mobilePhone.Add(phoneData[0], phoneData[1]);
            }
            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (!(input == "stop"))
        {
            if (mobilePhone.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}",input, mobilePhone[input]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.",input);
            }
            input = Console.ReadLine();
        }
    }
}
