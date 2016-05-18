//using System;

//class TradeComissionsVar2
//{
//    static void Main()
//    {
//        string city = Console.ReadLine().ToLower();
//        double sales = double.Parse(Console.ReadLine());
//        double comission = 0;

//        if (city == "sofia")
//        {
//            if (0.09 < sales && sales <= 500) comission = 0.05;
//            else if (500 < sales && sales <= 1000) comission = 0.07;
//            else if (1000 < sales && sales <= 10000) comission = 0.08;
//            else if (10000 < sales) comission = 0.12;
//        }
//        else if (city == "varna")
//        {
//            if (0.11 < sales && sales <= 500) comission = 0.045;
//            else if (500 < sales && sales <= 1000) comission = 0.075;
//            else if (1000 < sales && sales <= 10000) comission = 0.10;
//            else if (10000 < sales) comission = 0.13;
//        }
//        else if (city == "plovdiv")
//        {
//            if (0.09 < sales && sales <= 500) comission = 0.055;
//            else if (500 < sales && sales <= 1000) comission = 0.08;
//            else if (1000 < sales && sales <= 10000) comission = 0.12;
//            else if (10000 < sales) comission = 0.145;
//        }
//        if (comission * sales == 0) Console.WriteLine("error");
//        else Console.WriteLine("{0:F2}", comission * sales);
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commissions = -1.0;
            if (town == "Sofia")
            {
                if (0 <= sales && sales <= 500) commissions = 0.05;
                else if (500 <= sales && sales <= 1000) commissions = 0.07;
                else if (1000 <= sales && sales <= 10000) commissions = 0.08;
                else if (sales >= 10000) commissions = 0.05;
            }
            else if (town == "Varna")
            {
                if (0 <= sales && sales <= 500) commissions = 0.045;
                else if (500 <= sales && sales <= 1000) commissions = 0.075;
                else if (1000 <= sales && sales <= 10000) commissions = 0.10;
                else if (sales >= 10000) commissions = 0.13;
            }
            else if (town == "Plovdiv")
            {
                if (0 <= sales && sales <= 500) commissions = 0.055;
                else if (500 <= sales && sales <= 1000) commissions = 0.08;
                else if (1000 <= sales && sales <= 10000) commissions = 0.12;
                else if (sales >= 10000) commissions = 0.145;
            }
            if (commissions >= -1.0)
            {
                Console.WriteLine("{0:f2}", (commissions * sales));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
