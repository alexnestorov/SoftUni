//using System;

//class RectangleArea
//{
//    static void Main()
//    {
//        var x1 = double.Parse(Console.ReadLine());
//        var y1 = double.Parse(Console.ReadLine());
//        var x2 = double.Parse(Console.ReadLine());
//        var y2 = double.Parse(Console.ReadLine());
//        var area = Math.Abs((x1 - x2) * (y1 - y2));
//        var perimeter = 2 * (Math.Abs((x1 - x2)) + Math.Abs((y1 - y2)));
//        Console.WriteLine("Area = {0}\nPerimeter = {1}",area, perimeter);
//        }
//}
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var width = Math.Abs(x2 - x1);
            var height = Math.Abs(y2 - y1);

            Console.WriteLine("Area: {0}", width * height);
            Console.WriteLine("Perimeter: {0}", 2 * (width + height));
        }
    }
}