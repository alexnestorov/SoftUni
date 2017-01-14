using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main()
    {
        var resourcesQuantity = new Dictionary<string, int>();
        string command = Console.ReadLine();
        int count = 1;
        string resource = string.Empty;
        while (command!="stop")
        {
            if (count % 2 == 1)
            {
                resource = command;
                if (!(resourcesQuantity.ContainsKey(command)))
                {
                    resourcesQuantity.Add(command, 0);
                }
            }
            else
            {
                resourcesQuantity[resource] += int.Parse(command.ToString());
            }
            command = Console.ReadLine();
            count++;
        }
        foreach (var item in resourcesQuantity)
        {
            Console.WriteLine("{0} -> {1}", item.Key,item.Value);
        }
    }
}
