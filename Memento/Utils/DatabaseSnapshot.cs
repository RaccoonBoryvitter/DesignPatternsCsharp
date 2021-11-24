using Memento.Db;
using Memento.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Utils
{
    internal class DatabaseSnapshot : ISnapshot
    {

        public List<Division> Divisions { get; private set; }

        public List<Driver> Drivers { get; private set; }

        public List<Vehicle> Vehicles { get; private set; }

        public string Title { get; set; }

        public DateTime Timestamp { get; set; }

        public DatabaseSnapshot(
            List<Division> divisions,
            List<Driver> drivers,
            List<Vehicle> vehicles,
            string title,
            DateTime timestamp)
        {
            Divisions = new List<Division>(divisions);
            Drivers = new List<Driver>(drivers);
            Vehicles = new List<Vehicle>(vehicles);
            Title = title;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"{Timestamp:yyyyMMddHHmmss}_{Title}";
        }
    }
}
