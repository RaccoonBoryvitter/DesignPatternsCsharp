using Memento.Db;
using Memento.Entities;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext dbContext = new AppDbContext();
            DbCaretaker caretaker = new DbCaretaker(dbContext);

            caretaker.SaveChanges("Initializing DB");
            Console.WriteLine("Current drivers: ");
            dbContext.Drivers.ForEach(item => Console.WriteLine(item.Name));

            Driver newDriver = new Driver
            {
                Id = Guid.NewGuid(),
                Name = "Vova",
                Age = 37,
                Category = DriverCategory.C1,
                Division = dbContext.Divisions[2]
            };

            dbContext.Drivers.Add(newDriver);

            caretaker.SaveChanges("AddOneDriver");
            Console.WriteLine("Current drivers: ");
            dbContext.Drivers.ForEach(item => Console.WriteLine(item.Name));

            dbContext.Drivers.Remove(newDriver);

            caretaker.SaveChanges("DeleteOneDriver");
            Console.WriteLine("Current drivers: ");
            dbContext.Drivers.ForEach(item => Console.WriteLine(item.Name));

            caretaker.GetHistory();

            Console.WriteLine("Rollback to previous snapshot:");
            caretaker.Rollback();
            Console.WriteLine("Current drivers: ");
            dbContext.Drivers.ForEach(item => Console.WriteLine(item.Name));
        }
    }
}
