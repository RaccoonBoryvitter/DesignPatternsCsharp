using Memento.Entities;
using Memento.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Memento.Db
{
    internal class AppDbContext
    {

        public List<Division> Divisions { get; set; }

        public List<Driver> Drivers { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public AppDbContext()
        {
            Divisions = new List<Division>
            {
                new Division
                {
                    Id = Guid.NewGuid(),
                    Title = "Division #1",
                    City = "Chernivtsi",
                    Address = "Nebesnoyi Sotni, 4B",
                },
                new Division
                {
                    Id = Guid.NewGuid(),
                    Title = "Division #2",
                    City = "Khmelnytskyi",
                    Address = "Golovna, 352",
                },
                new Division
                {
                    Id = Guid.NewGuid(),
                    Title = "Division #3",
                    City = "Sokyryany",
                    Address = "Peremogy, 14",
                },
            };

            Drivers = new List<Driver>
            {
                new Driver
                {
                    Id = Guid.NewGuid(),
                    Name = "Ivan",
                    Age = 26,
                    Category = DriverCategory.C1,
                    Division = Divisions[0],
                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    Name = "Vasyl",
                    Age = 29,
                    Category = DriverCategory.C,
                    Division = Divisions[0],
                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    Name = "Stepan",
                    Age = 35,
                    Category = DriverCategory.C1_E,
                    Division = Divisions[1],
                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    Name = "Petro",
                    Age = 41,
                    Category = DriverCategory.C_E,
                    Division = Divisions[1],
                },
                new Driver
                {
                    Id = Guid.NewGuid(),
                    Name = "Pavel",
                    Age = 19,
                    Category = DriverCategory.C1,
                    Division = Divisions[2],
                },
            };

            Vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Id = Guid.NewGuid(),
                    LicensePlate = "CE1111AE",
                    WeightCapacity = 25.0,
                    Driver = Drivers[0],
                    Division = Divisions[0],
                },
                new Vehicle
                {
                    Id = Guid.NewGuid(),
                    LicensePlate = "BX2222IA",
                    WeightCapacity = 20.0,
                    Driver = Drivers[2],
                    Division = Divisions[1],
                },
                new Vehicle
                {
                    Id = Guid.NewGuid(),
                    LicensePlate = "CE3333EE",
                    WeightCapacity = 28.0,
                    Driver = Drivers[4],
                    Division = Divisions[2],
                },
            };
        }

        public DatabaseSnapshot SaveSnapshot(string title, DateTime timestamp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Saving snapshot \"{title}\".");
            Console.ForegroundColor = ConsoleColor.White;

            return new DatabaseSnapshot(Divisions, Drivers, Vehicles, title, timestamp);
        }

        public void Restore(DatabaseSnapshot snapshot)
        {
            Divisions = snapshot.Divisions;
            Drivers = snapshot.Drivers;
            Vehicles = snapshot.Vehicles;
        }
    }
}
