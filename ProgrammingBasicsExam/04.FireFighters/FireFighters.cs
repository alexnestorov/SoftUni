using System;

class FireFighters
{
    static void Main()
    {
        // Input data and declared variables
        int fireFighters = int.Parse(Console.ReadLine());
        string peopleToRescue = "";
        int kids = 0;
        int adults = 0;
        int seniors = 0;
        int fireFightersCount = fireFighters;

        while (true)
        {
            peopleToRescue = Console.ReadLine().ToLower();
            // If enter rain the loop is over.
            if (peopleToRescue == "rain")
            {
                break;
            }
            // Check peopleToRescue are less or equal to the firefighters and rescue all people.
            if (peopleToRescue.Length <= fireFighters)
            {
                for (int count = 0; count < peopleToRescue.Length; count++, fireFightersCount--)
                {
                    if (peopleToRescue[count] == 'k')
                    {
                        kids++;
                    }
                    else if (peopleToRescue[count] == 'a')
                    {
                        adults++;
                    }
                    else if (peopleToRescue[count] == 's')
                    {
                        seniors++;
                    }
                }
            }
            // Check if peopleToRescue is more than the firefighters.
            else if (peopleToRescue.Length > fireFighters)
            {
                // Loop over the string and sum the rescued kids.
                for (int k = 0; k < peopleToRescue.Length; k++)
                {
                    if (fireFightersCount == 0)
                    {
                        break;
                    }
                    if (peopleToRescue[k] == 'k')
                    {
                        kids++;
                        fireFightersCount--;
                    }
                }
                // Check for left firefighters.
                // Loop over the string and sum the rescued adults.
                if (fireFightersCount > 0)
                {
                    for (int a = 0; a < peopleToRescue.Length; a++)
                    {
                        if (fireFightersCount == 0)
                        {
                            break;
                        }

                        if (peopleToRescue[a] == 'a')
                        {
                            adults++;
                            fireFightersCount--;
                        }
                    }
                }
                // Check for left firefighters.
                // Loop over the string and sum the rescued seniors.
                if (fireFightersCount > 0)
                {
                    for (int s = 0; s < peopleToRescue.Length; s++)
                    {
                        if (fireFightersCount == 0)
                        {
                            break;
                        }
                        if (peopleToRescue[s] == 's')
                        {
                            seniors++;
                            fireFightersCount--;
                        }
                    }
                }
            }
            fireFightersCount = fireFighters;
        }

        // Output data. Sum of rescued kids, adults and seniors.
        Console.WriteLine("Kids: {0}\nAdults: {1}\nSeniors: {2}\n", kids, adults, seniors);
    }
}
