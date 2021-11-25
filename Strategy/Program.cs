using Strategy.Entity;
using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    Name = "First client",
                    City = "Chernivtsi",
                },
                new Client
                {
                    Name = "Second client",
                    City = "Khmelnytskyi",
                },
                new Client
                {
                    Name = "Third client",
                    City = "Sokyryany",
                },
            };

            List<Freight> freights = new List<Freight>
            {
                new Freight
                {
                    Weight = 15.0,
                    Description = "Desc 1",
                },
                new Freight
                {
                    Weight = 23.0,
                    Description = "Desc 2",
                },
                new Freight
                {
                    Weight = 4.2,
                    Description = "Desc 3",
                },
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Truck { WeightCapacity = 32.0 },
                new Ship { WeightCapacity = 55.0 },
                new Plane { WeightCapacity = 10.0 },
            };

            List<Order> orders = new List<Order>
            {
                new Order
                {
                    Client = clients[0],
                    Freight = freights[0],
                    Destination = "Ivano-Frankivsk",
                    Vehicle = vehicles[0],
                },
                new Order
                {
                    Client = clients[1],
                    Freight = freights[1],
                    Destination = "Lviv",
                    Vehicle = vehicles[1],
                },
                new Order
                {
                    Client = clients[2],
                    Freight = freights[2],
                    Destination = "Khmelnytskyi",
                    Vehicle = vehicles[2],
                },
            };

            orders.ForEach(i => i.Dispatch());
        }
    }
}
