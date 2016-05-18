using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Bottom
    {
        get
        {
            return Top + Width;
        }
    }
    public int Right
    {
        get
        {
            return Left + Height;
        }
    }
    public int CalculationArea()
    {
        return Width * Height;
    }
    public bool IsInside(Rectangle r)
        {
        return r.Left <= Left && r.Right >= Right && r.Top <= Top && r.Bottom >= Bottom;  
        }
}
class RectanglePosition
{
    static void Main()
    {
        Rectangle r1 = ReadRectangle();
        Rectangle r2 = ReadRectangle();
        if (r1.IsInside(r2))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
    private static Rectangle ReadRectangle()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Rectangle r = new Rectangle() { Top = nums[0], Left = nums[1], Width = nums[2], Height = nums[3]};
        return r;
    }
}
