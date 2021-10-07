using Bridge.Models;
using System;

namespace Bridge
{
    internal class Application
    {
        static void Main(string[] args)
        {
            Freight[] freights = new Freight[]
            {
                new Freight("Chernivsi", "Khmelnytskyi", 750.0, "Some sort of description #1"),
                new Freight("Ivano-Frankivsk", "Khmelnytskyi", 920.0, "Some sort of description #2"),
                new Freight("Chernivsi", "Ivano-Frankivsk", 1080.0, "Some sort of description #3")
            };

            CargoVehicle truck1 = new CargoTruck(80);
            CargoVehicle truck2 = new CargoTruck(90);
            CargoVehicle plane = new CargoPlane(600);

            Passage passage1 = new Passage(plane, freights[1], new DateTime(2021, 10, 8, 9, 0, 0), new DateTime(2021, 10, 8, 10, 0, 0));
            Passage passage2 = new ExpressPassage(truck1, freights[0], new DateTime(2021, 10, 8, 12, 0, 0), new DateTime(2021, 10, 8, 19, 0, 0));
            Passage passage3 = new RegularPassage(truck2, freights[2], new DateTime(2021, 10, 8, 9, 0, 0), new DateTime(2021, 10, 8, 22, 0, 0));

            passage1.Run();
            passage2.Run();
            passage3.Run();
        }
    }
}
