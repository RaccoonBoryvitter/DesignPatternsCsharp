using Pool.Models;
using System;
using System.Collections.Generic;

namespace Pool
{
    internal class Application
    {
        internal static void Main(string[] args)
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

            Company company = new Company();
            company.Freights = freights;
            company.RunDeliveryThreads(freights.Count);

            Console.WriteLine("\n=========================================================\n");

            company.RunDeliveryThreads(freights.Count);
        }
    }
}
