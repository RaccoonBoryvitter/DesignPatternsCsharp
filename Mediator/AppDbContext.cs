using Mediator.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class AppDbContext
    {
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public AppDbContext()
        {
            Drivers = new List<Driver>
            {
                new Driver { Name = "Іванов Іван Іванович" },
                new Driver { Name = "Петров Петро Петрович" },
                new Driver { Name = "Ще якесь ім'я але мені лінь придумати" },
            };

            Vehicles = new List<Vehicle>
            { 
                new Vehicle { Name = "Volvo", WeightCapacity = 8 },
                new Vehicle { Name = "Mercedes-Benz", WeightCapacity = 12 },
                new Vehicle { Name = "UAZ-2101", WeightCapacity = 3 },
            };
        }
    }
}
