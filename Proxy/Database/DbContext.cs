using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Database
{
    internal class DbContext
    {
        public List<CargoTransport> Transports { get; set; }

        public List<Manager> Managers { get; set; }

        public DbContext()
        {
            Transports = new List<CargoTransport>
            {
                new CargoTransport
                {
                    Name = "Volvo 32413",
                    MaxSpeed = 250,
                    FuelCapacity = 220,
                },
                new CargoTransport
                {
                    Name = "Mercedes-Benz 526626",
                    MaxSpeed = 280,
                    FuelCapacity = 200,
                },
                new CargoTransport
                {
                    Name = "DAF 626465",
                    MaxSpeed = 260,
                    FuelCapacity = 210,
                },
            };

            Managers = new List<Manager>
            {
                new Manager
                {
                    Login = "superadmin",
                    Password = "qwerty",
                    Permissions = Enums.ManagerPermissions.ReadWriteUpdateDelete,
                },
                new Manager
                {
                    Login = "admin",
                    Password = "asdfgh",
                    Permissions = Enums.ManagerPermissions.ReadWrite,
                },
            };
        }

    }
}
