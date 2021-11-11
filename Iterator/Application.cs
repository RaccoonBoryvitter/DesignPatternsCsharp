using System;
using System.Collections.Generic;
using Iterator.Models;

namespace Iterator
{
    class Application
    {
        static void Main(string[] args)
        {
            var freights = new List<Freight>()
            {
                new Freight
                {
                    Weight = 412.53,
                    Material = MaterialType.Simple,
                    Security = SecurityType.Safe,
                    Description = "1"
                },
                new Freight
                {
                    Weight = 234.51,
                    Material = MaterialType.Liquid,
                    Security = SecurityType.Safe,
                    Description = "2"
                },
                new Freight
                {
                    Weight = 865.43,
                    Material = MaterialType.Fragile,
                    Security = SecurityType.Danger,
                    Description = "3"
                },
                new Freight
                {
                    Weight = 565.54,
                    Material = MaterialType.Liquid,
                    Security = SecurityType.Danger,
                    Description = "4"
                },
                new Freight
                {
                    Weight = 75.54,
                    Material = MaterialType.Simple,
                    Security = SecurityType.Danger,
                    Description = "5"
                },
            };

            var container = new CargoContainer();
            container.AddRange(freights);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Iterator goes straight from the beginning to the end...");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in container)
            {
                Console.WriteLine(item);
            }

            container.ToggleDirection();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Now iterator goes straight from the end to the beginning...");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in container)
            {
                Console.WriteLine(item);
            }
        }
    }
}
