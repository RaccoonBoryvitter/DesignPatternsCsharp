using Proxy.Database;
using Proxy.Models;
using Proxy.Services;
using System;
using System.Collections.Generic;

namespace Proxy
{
    internal class Application
    {
        static void Main(string[] args)
        {
            DbContext db = new DbContext();
            List<Manager> managers = db.Managers;
            Client client = new Client(managers);
            string login, password;

            do
            {
                Console.WriteLine("Please, enter your login: ");
                login = Console.ReadLine();
                Console.WriteLine("Please, enter your password: ");
                password = Console.ReadLine();
                if (login == string.Empty || password == string.Empty)
                    continue;
            } while (!client.Authorize(login, password));

            CargoTransport transport = new CargoTransport
            {
                Name = "test",
                MaxSpeed = 3413,
                FuelCapacity = 325235,
            };

            client.TransportService = new CargoTransportService(db);
            Console.WriteLine("Create: ");
            client.CreateTransport(transport);
            Console.WriteLine("Get All: ");
            client.GetAllTransports().ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Update: ");
            CargoTransport transport1 = new CargoTransport
            {
                Id = transport.Id,
                Name = transport.Name,
                MaxSpeed = transport.MaxSpeed,
                FuelCapacity = transport.FuelCapacity,
            };
            transport1.MaxSpeed = 1234;
            client.UpdateExistingTransport(transport);
            Console.WriteLine("Get All: ");
            client.GetAllTransports().ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Delete: ");
            client.DeleteExistingTransport(transport);
            Console.WriteLine("Get All: ");
            client.GetAllTransports().ForEach(item => Console.WriteLine(item));

            client.TransportService = new CargoTransportServiceProxy(
                new CargoTransportService(db),
                new LoggerService(),
                client.CurrentManager.Permissions);

            Console.WriteLine("Create: ");
            client.CreateTransport(transport);
            Console.WriteLine("Get All: ");
            client.GetAllTransports()?.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Update: ");
            transport1.MaxSpeed = 8786;
            client.UpdateExistingTransport(transport1);
            Console.WriteLine("Get All: ");
            client.GetAllTransports()?.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Delete: ");
            client.DeleteExistingTransport(transport);
            Console.WriteLine("Get All: ");
            client.GetAllTransports()?.ForEach(item => Console.WriteLine(item));
        }
    }
}
