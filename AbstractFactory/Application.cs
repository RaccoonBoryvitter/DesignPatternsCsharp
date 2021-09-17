using AbstractFactory.Models;
using AbstractFactory.Models.Logistics;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class Application
    {
        static void Main(string[] args)
        {
            List<Freight> freights = new List<Freight>
            {
                new Freight(12.7, DeliverType.Regular, "Freight #1"),
                new Freight(31.2, DeliverType.Regular, "Freight #2"),
                new Freight(33.56, DeliverType.Urgent, "Freight #3"),
                new Freight(13.83, DeliverType.Urgent, "Freight #4"),
                new Freight(12.54, DeliverType.Urgent, "Freight #5"),
                new Freight(21.76, DeliverType.Regular, "Freight #6"),
                new Freight(34.6, DeliverType.Urgent, "Freight #7"),
                new Freight(23.41, DeliverType.Urgent, "Freight #8"),
                new Freight(14.04, DeliverType.Regular, "Freight #9"),
                new Freight(26.3, DeliverType.Regular, "Freight #10"),
                new Freight(11.58, DeliverType.Regular, "Freight #11"),
                new Freight(20.05, DeliverType.Regular, "Freight #12"),
                new Freight(31.71, DeliverType.Regular, "Freight #13")
            };

            Company company = new Company(new TruckFactory())
            {
                Freights = freights
            };
            company.RunDeliveryThreads();

            Console.WriteLine("\n=========================================================\n");

            company.LogisticsFactory = new ShipFactory();
            company.RunDeliveryThreads();
        }
    }
}
