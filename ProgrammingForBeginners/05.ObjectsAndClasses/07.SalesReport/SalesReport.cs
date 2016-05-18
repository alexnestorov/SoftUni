using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define new class to set Sale parameters
class Sale
{
    public string town { get; set; }
    public string product { get; set; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }
    public decimal amountProduct()
    {
        return price * quantity;
    }
}
class SalesReport
{
    static void Main()
    {
        int numberOfSales = int.Parse(Console.ReadLine());
        Dictionary<string, decimal> salesReport = new Dictionary<string, decimal>();
        CalculateSalesForeachTown(numberOfSales, salesReport);
        // Sort alphabetically in new variable
        var result = salesReport.OrderBy(s => s.Key);
        PrintSalesReport(result);
    }

    private static void PrintSalesReport(IOrderedEnumerable<KeyValuePair<string, decimal>> result)
    {
        foreach (var item in result)
        {
            Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
        }
    }

    private static void CalculateSalesForeachTown(int numberOfSales, Dictionary<string, decimal> salesReport)
    {
        for (int i = 0; i < numberOfSales; i++)
        {
            Sale eachSale = ReadSales();
            if (salesReport.ContainsKey(eachSale.town))
            {
                salesReport[eachSale.town] += eachSale.amountProduct();
            }
            else
            {
                salesReport.Add(eachSale.town, eachSale.amountProduct());
            }
        }
    }

    // Method for reading each sale
    public static Sale ReadSales()
    {
        List<string> salesInfo = Console.ReadLine().Split(' ').ToList();
        Sale sale = new Sale()
        {
            town = salesInfo[0],
            product = salesInfo[1],
            price = decimal.Parse(salesInfo[2]),
            quantity = decimal.Parse(salesInfo[3])
        };
        return sale;
    }
}