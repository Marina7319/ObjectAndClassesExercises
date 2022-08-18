using System;
using System.Linq;
using System.Collections.Generic;
namespace _6.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokens = "";
            List<Vehicle> vehList = new List<Vehicle>();
            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(separator: new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs[0] == "End")
                {
                    break;
                }
                if (inputArgs[0] == "car")
                {
                    tokens = "Car";
                }
                else
                {
                    tokens = "Truck";
                }
                var vehiclesss = new Vehicle(tokens, inputArgs[1], inputArgs[2], int.Parse(inputArgs[3]));
                vehList.Add(vehiclesss);
                //VehicleType vehicleType;
                // bool isVehicleTypeParseSuccesful = Enum.TryParse(inputArgs[0], ignoreCase: true, out vehicleType);
            }
            string input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                string vehicle = input;

                foreach (Vehicle veh in vehList)
                {
                    if (vehicle == veh.Model)
                    {
                        Console.WriteLine(veh);
                    }
                }
                input = Console.ReadLine();
            }
            double firstCount = 0;
            double secondCount = 0;
            double avgHorsepowerFirst = 0;
            double avgHorsepowerSecond = 0;
            foreach (Vehicle veh in vehList)
            {
                if (veh.Type == tokens)
                {
                    avgHorsepowerFirst += veh.Horsepower;
                    firstCount++;
                }
                else
                {
                    secondCount++;
                    avgHorsepowerSecond += veh.Horsepower;
                }
            }
            if (firstCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avgHorsepowerFirst / firstCount:f2}.");
            }
            if (secondCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avgHorsepowerSecond / secondCount:f2}.");
            }
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public override string ToString() => $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
    }
}
