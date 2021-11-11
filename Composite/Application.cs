using System;

namespace Composite
{
    internal class Application
    {
        static void Main(string[] args)
        {
            ICargo[] cargos = new ICargo[]
            {
                new Freight { Weight = 380.30M, Description = "Freight #1" },
                new Freight { Weight = 650.20M, Description = "Freight #2" },
                new Freight { Weight = 1321.00M, Description = "Freight #3" },
                new Freight { Weight = 983.60M, Description = "Freight #4" },
                new LiquidFreight { Volume = 632.00M, Density = LiquidType.Water, Description = "Liquid Freight #1" },
                new LiquidFreight { Volume = 711.00M, Density = LiquidType.CarOil, Description = "Liquid Freight #2" },
                new LiquidFreight { Volume = 260.00M, Density = LiquidType.Alcohol, Description = "Liquid Freight #3" },
            };

            CargoContainer container = new CargoContainer();
            container.AddRange(cargos);

            Console.WriteLine($"Overall weight: {container.GetWeight()}");
            Console.WriteLine($"{container.Description}");
        }
    }
}
