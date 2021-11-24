using Observer.Db;
using Observer.Utils;
using System;
using System.Linq;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();
            Logistics logistics = new Logistics(dbContext.Divisions);

            logistics.Divisions.ForEach(div => dbContext.Drivers.Where(d => d.Division == div)
                               .ToList()
                               .ForEach(driver => div.Add(driver)));
            logistics.Divisions.ForEach(div => dbContext.Vehicles.Where(v => v.Division == div)
                               .ToList()
                               .ForEach(vehicle => div.Add(vehicle)));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStep 1: when all are subscribed\n");
            Console.ForegroundColor = ConsoleColor.White;
            dbContext.Orders.ForEach(o => logistics.MakeOrder(o));

            dbContext.Drivers.Where(d => d.Division.City == "Sokyryany")
                             .ToList()
                             .ForEach(driver => logistics.Divisions.ForEach(d => d.Remove(driver)));

            dbContext.Vehicles.Where(v => v.Division.City == "Sokyryany")
                              .ToList()
                              .ForEach(vehicle => logistics.Divisions.ForEach(d => d.Remove(vehicle)));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStep 2 when some observers are unsubscribed\n");
            Console.ForegroundColor = ConsoleColor.White;
            dbContext.Orders.ForEach(o => logistics.MakeOrder(o));
        }
    }
}
