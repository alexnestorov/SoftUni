using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UniqueUsernames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var uniqueUsernames = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            string username = Console.ReadLine();
            uniqueUsernames.Add(username);
        }
        foreach (var user in uniqueUsernames)
        {
            Console.WriteLine(user);
        }
    }
}
