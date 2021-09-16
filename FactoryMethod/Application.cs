using FactoryMethod.Models;
using FactoryMethod.Models.Logistics;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class Application
    {
        static void Main(string[] args)
        {
            List<Freight> freights = new List<Freight>
            { 
                new Freight(12.7, "Freight #1"),
                new Freight(31.2, "Freight #1"),
                new Freight(33.56, "Freight #1"),
                new Freight(13.83, "Freight #1"),
                new Freight(12.54, "Freight #1"),
                new Freight(21.76, "Freight #1"),
                new Freight(34.6, "Freight #1"),
                new Freight(23.41, "Freight #1"),
                new Freight(14.04, "Freight #1"),
                new Freight(26.3, "Freight #1"),
                new Freight(11.58, "Freight #1"),
                new Freight(20.05, "Freight #1"),
                new Freight(31.71, "Freight #1")
            };

            Company company = new Company(new TruckDepartment());
            company.Freights = freights;
            company.RunDeliveryThreads(freights.Count);

            Console.WriteLine("\n=========================================================\n");

            company.LogisticsDepartment = new ShipDepartment();
            company.RunDeliveryThreads(freights.Count);
        }
    }
}
