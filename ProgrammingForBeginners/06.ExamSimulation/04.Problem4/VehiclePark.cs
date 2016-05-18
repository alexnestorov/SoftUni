using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VehiclePark
{
    static void Main()
    {
        List<string> carPark = Console.ReadLine().Split(' ').ToList();
        string[] command = Console.ReadLine().Split(' ').ToArray();
        string vehicle = "";
        int countSold = 0;
        while (true)
        {
            if (command[0].ToLower().Contains("end"))
            {
                break;
            }
            vehicle = command[0].ToLower().Substring(0,1) + command[2];
            if (carPark.Contains(vehicle))
            {
                int typeOfVehicle = (char)vehicle[0];   
                int seats = int.Parse(vehicle.Substring(1));
                int price = typeOfVehicle * seats;
                Console.WriteLine("Yes, sold for {0}$", price);
                countSold++;
            }
            else
            {
                Console.WriteLine("No");
            }
            carPark.Remove(vehicle);
            command = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine("Vehicles left: {0}", string.Join(", ", carPark));
        Console.WriteLine("Vehicles sold: {0}", countSold);
    }
}
