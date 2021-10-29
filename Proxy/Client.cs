using Proxy.Database;
using System.Linq;
using System.Collections.Generic;
using System;
using Proxy.IServices;
using Proxy.Models;

namespace Proxy
{
    internal class Client
    {
        public ICargoTransportService TransportService { get; set; }

        public List<Manager> Managers { get; set; }

        public Manager CurrentManager { get; set; }

        public Client(List<Manager> managers)
        {
            Managers = managers;
        }

        public bool Authorize(string login, string password)
        {
            var matches = Managers.First(m => m.Login == login
                                                           && m.Password == password);
            if (matches == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WARNING! Bad credentials.");
                Console.WriteLine("Please, try again:");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            CurrentManager = matches;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome back, {login}!");
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }

        public List<CargoTransport> GetAllTransports()
        {
            return TransportService.All();
        }

        public void CreateTransport(CargoTransport transport)
        {
            TransportService.Insert(transport);
        }

        public void UpdateExistingTransport(CargoTransport transport)
        {
            TransportService.Update(transport);
        }

        public void DeleteExistingTransport(CargoTransport transport)
        {
            TransportService.Delete(transport);
        }
    }
}
