using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogs
{
    static void Main()
    {
        var domainAddress = new Dictionary<string, Dictionary<string, int>>();

        string[] input = Console.ReadLine().Split(' ').ToArray();

        while (!input.Contains("end"))
        {
            string[] ip = input[0].Split('=').ToArray();
            string[] domain = input[2].Split('=').ToArray();
            if (domainAddress.ContainsKey(ip[1]))
            {
                var address = new Dictionary<string, int>();
                address.Add(ip[1], 1);
                domainAddress[domain[1]].Add(address.Keys, address.Values);
            }

            input = Console.ReadLine().Split(' ').ToArray();
        }

    }
}
