using Observer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Db
{
    internal class AppDbContext
    {
        public List<Division> Divisions { get; set; }

        public List<Driver> Drivers { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public List<Client> Clients { get; set; }

        public List<Freight> Freights { get; set; }

        public List<Order> Orders { get; set; }

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

            Clients = new List<Client>
            {
                new Client
                {
                    Id = Guid.NewGuid(),
                    Name = "OAO",
                    City = "Chernivtsi",
                },
                new Client
                {
                    Id = Guid.NewGuid(),
                    Name = "AOA",
                    City = "Khmelnytskyi",
                },
                new Client
                {
                    Id = Guid.NewGuid(),
                    Name = "UwU",
                    City = "Sokyryany",
                },
            };

            Freights = new List<Freight>
            {
                new Freight
                {
                    Id = Guid.NewGuid(),
                    Weight = 15.0,
                    Description = "Lorem ipsum",
                },
                new Freight
                {
                    Id = Guid.NewGuid(),
                    Weight = 22.0,
                    Description = "Dorime",
                },
                new Freight
                {
                    Id = Guid.NewGuid(),
                    Weight = 27.0,
                    Description = "Interimo adapare",
                },
            };

            Orders = new List<Order>
            {
                new Order
                {
                    Id = Guid.NewGuid(),
                    Client = Clients[0],
                    Freight = Freights[0],
                },
                new Order
                {
                    Id = Guid.NewGuid(),
                    Client = Clients[1],
                    Freight = Freights[1],
                },
                new Order
                {
                    Id = Guid.NewGuid(),
                    Client = Clients[2],
                    Freight = Freights[2],
                },
            };
        }
    }

}
