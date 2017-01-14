using System;
using System.Collections.Generic;

class FixEmails
{
    static void Main()
    {
        var resourcesQuantity = new Dictionary<string, string>();
        string command = Console.ReadLine();
        int count = 1;
        string resource = string.Empty;
        while (command != "stop")
        {
            if (count % 2 == 1)
            {
                resource = command;
                if (!(resourcesQuantity.ContainsKey(command)))
                {
                    resourcesQuantity.Add(command, "");
                }
            }
            else
            {
                resourcesQuantity[resource] += command;
            }
            command = Console.ReadLine();
            count++;
        }
        foreach (var item in resourcesQuantity)
        {
            if (!item.Value.EndsWith("us") && !item.Value.EndsWith("uk"))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
