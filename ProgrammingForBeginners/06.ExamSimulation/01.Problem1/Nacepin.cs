using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Nacepin
{
    static void Main()
    {
        double priceUS = double.Parse(Console.ReadLine());
        uint kgUS = uint.Parse(Console.ReadLine());
        double priceUK = double.Parse(Console.ReadLine());
        uint kgUk = uint.Parse(Console.ReadLine());
        double priceCH = double.Parse(Console.ReadLine());
        uint kgCH = uint.Parse(Console.ReadLine());

        double storeUS = (priceUS)/ 0.58;
        double storeUK = (priceUK) / 0.41;
        double storeCH = priceCH * 0.27;
        double storeUSper1 = storeUS / kgUS;
        double storeUKper1 = storeUK / kgUk;
        double storeCHper1 = storeCH / kgCH;
        double max = Math.Max(storeUSper1, Math.Max(storeUKper1, storeCHper1));
        double min = Math.Min(storeUSper1, Math.Min(storeUKper1, storeCHper1));
        if (storeCHper1 < storeUKper1 && storeCHper1 < storeUSper1)
        {
            Console.WriteLine("Chinese store. {0:F2} lv/kg", storeCHper1);
            Console.WriteLine("Difference {0:F2} lv/kg", max - min);
        }
        else if (storeUKper1 < storeCHper1 && storeUKper1 < storeUSper1)
        {
            Console.WriteLine("UK store. {0:F2} lv/kg", storeUKper1);
            Console.WriteLine("Difference {0:F2} lv/kg", max - min);
        }
        else if (storeUSper1 < storeUKper1 && storeUSper1 < storeCHper1)
        {
            Console.WriteLine("US store. {0:F2} lv/kg", storeUSper1);
            Console.WriteLine("Difference {0:F2} lv/kg", max - min);
        }



    }
}

