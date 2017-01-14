using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DragonArmy
{
    static void Main()
    {
        int numberOfDragons = int.Parse(Console.ReadLine());
        decimal defaultDamage = 45;
        decimal defaultHealth = 250;
        decimal defaultArmor = 10;


        var names = new SortedDictionary<string, string>();
        var dicitonaryDamage = new SortedDictionary<string, int>();
        var dicitonaryHealth = new SortedDictionary<string, int>();
        var dicitonaryArmor = new SortedDictionary<string, int>();
        for (int i = 0; i < numberOfDragons; i++)
        {
            string[] inputline = Console.ReadLine()
                                        .Split(' ')
                                        .ToArray();
            SetVaueFromNull(defaultDamage, defaultHealth, defaultArmor, inputline);
            if (!names.ContainsKey(inputline[0]))
            {
                names.Add(inputline[0], inputline[1]);
            }
            else
            {
                names[inputline[0]] += " " + inputline[1];
            }

            if (!dicitonaryDamage.ContainsKey(inputline[1]))
            {
                dicitonaryDamage.Add(inputline[1], (int.Parse)(inputline[2]));
            }
            else
            {
                dicitonaryDamage[inputline[1]] = (int.Parse)(inputline[2]);
            }

            if (!dicitonaryHealth.ContainsKey(inputline[1]))
            {
                dicitonaryHealth.Add(inputline[1], (int.Parse)(inputline[3]));
            }
            else
            {
                dicitonaryHealth[inputline[1]] = (int.Parse)(inputline[3]);
            }
            if (!dicitonaryArmor.ContainsKey(inputline[1]))
            {
                dicitonaryArmor.Add(inputline[1], (int.Parse)(inputline[4]));
            }
            else
            {
                dicitonaryArmor[inputline[1]] = (int.Parse)(inputline[4]);
            }
        }


        foreach (var name in names)
        {
            decimal damageAvg = 0;
            decimal healthAvg = 0;
            decimal armorAvg = 0;
            string[] cities = name.Value.Split(' ').ToArray();
            var orderedCities = cities.OrderBy(x => x);
            foreach (var check in orderedCities)
            {
                foreach (var damage in dicitonaryDamage)
                {
                    if (check.Contains(damage.Key))
                    {
                        damageAvg += damage.Value;
                    }
                }
                foreach (var health in dicitonaryHealth)
                {
                    if (check.Contains(health.Key))
                    {
                        healthAvg += health.Value;
                    }
                }
                foreach (var armor in dicitonaryArmor)
                {
                    if (check.Contains(armor.Key))
                    {
                        armorAvg += armor.Value;
                    }
                }
            }
            damageAvg /= cities.Length;
            healthAvg /= cities.Length;
            armorAvg /= cities.Length;
            Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", name.Key, damageAvg, healthAvg, armorAvg);

            foreach (var check in orderedCities)
            {
                foreach (var damage in dicitonaryDamage)
                {
                    if (check.Contains(damage.Key))
                    {
                        Console.Write("-{0} -> damage: {1},", damage.Key, damage.Value);
                    }
                }
                foreach (var health in dicitonaryHealth)
                {
                    if (check.Contains(health.Key))
                    {
                        Console.Write(" health: {0},", health.Value);
                    }
                }
                foreach (var armor in dicitonaryArmor)
                {
                    if (check.Contains(armor.Key))
                    {
                        Console.Write(" armor: {0}", armor.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }

    static void SetVaueFromNull(decimal defaultDamage, decimal defaultHealth, decimal defaultArmor, string[] inputline)
    {
        if (inputline[2] == "null")
        {
            inputline[2] = defaultDamage.ToString();
        }
        if (inputline[3] == "null")
        {
            inputline[3] = defaultHealth.ToString();
        }
        if (inputline[4] == "null")
        {
            inputline[4] = defaultArmor.ToString();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//public class DragonPower
//{
//    public static void Main()
//    {
//        Dictionary<string, SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>> dragons = new Dictionary<string, SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>>();
//        var colorDragon = "";
//        var typeDragon = "";
//        double damageDragon = 0;
//        double healthDragon = 0;
//        double armorDragon = 0;
//        int n = int.Parse(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            var input = Console.ReadLine();
//            //input = input.Replace("null", "0");
//            var comand = input.Split().ToArray();
//            damageDragon = 45;
//            healthDragon = 250;
//            armorDragon = 10;
//            colorDragon = comand[0];
//            typeDragon = comand[1];
//            if (comand[2] != "null")
//            {
//                damageDragon = double.Parse(comand[2]);
//            }
//            if (comand[3] != "null")
//            {
//                healthDragon = double.Parse(comand[3]);
//            }
//            if (comand[4] != "null")
//            {
//                armorDragon = double.Parse(comand[4]);
//            }

//            if (!dragons.ContainsKey(colorDragon))
//            {
//                dragons[colorDragon] = new SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>();
//            }
//            if (!dragons[colorDragon].ContainsKey(typeDragon))
//            {
//                dragons[colorDragon][typeDragon] = new SortedDictionary<double, SortedDictionary<double, double>>();
//            }
//            if (!dragons[colorDragon][typeDragon].ContainsKey(damageDragon))
//            {
//                dragons[colorDragon][typeDragon][damageDragon] = new SortedDictionary<double, double>();
//                dragons[colorDragon][typeDragon][damageDragon].Add(healthDragon, armorDragon);
//            }
//        }

//        foreach (var drakon in dragons)
//        {
//            double dmg = 0;
//            double healt = 0;
//            double arm = 0;
//            var x = dragons[colorDragon][typeDragon][damageDragon].Keys;
//            foreach (var color in dragons[drakon.Key])
//            {
//                foreach (var type in dragons[drakon.Key][color.Key])
//                {
//                    dmg += type.Key;
//                    foreach (var damage in dragons[drakon.Key][color.Key][type.Key])
//                    {
//                        healt += damage.Key;
//                        arm += damage.Value;
//                    }
//                }
//            }
//            Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", drakon.Key, dmg / drakon.Value.Count , healt / drakon.Value.Count, arm / drakon.Value.Count);
//            foreach (var color in dragons[drakon.Key])
//            {
//                Console.Write("-{0} -> ", color.Key);
//                foreach (var type in dragons[drakon.Key][color.Key])
//                {
//                    Console.Write("damage: {0}, ", type.Key);
//                    foreach (var damage in dragons[drakon.Key][color.Key][type.Key])
//                    {
//                        Console.Write("health: {0}, armor: {1}", damage.Key, damage.Value);
//                    }
//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}
