using Mediator.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.MediatR
{
    internal class Manager : IMediatR
    {
        public Client Client { get; set; }

        public Logistics Logistics { get; set; }

        public Report Report { get; set; }

        public Manager(Client client, Logistics logistics)
        {
            Client = client;
            Client.Mediator = this;
            Logistics = logistics;
            Logistics.Mediator = this;
            Report = new Report();
        }

        public void Notify(object sender, EventComponent evt)
        {
            bool success = false;

            switch(evt.Type)
            {
                case "OnDispatchOrder":
                    {
                        Console.WriteLine("Receiving new order...");
                        Report.From = sender as Client;
                        Report.Freight = evt.Args[0] as Freight;
                        Report.To = evt.Args[1] as Client;
                        Console.WriteLine("Finding vehicle for this task...");
                        Logistics.FindVehicle(Report.Freight);
                        break;
                    }
                case "OnVehicleNotFound":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(evt.Args[0] as string);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "OnVehicleFoundSuccess":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(evt.Args[1] as string);
                        Console.ForegroundColor = ConsoleColor.White;
                        Report.Vehicle = evt.Args[0] as Vehicle;
                        Console.WriteLine("Finding driver...");
                        Logistics.FindDriver();
                        break;
                    }
                case "OnDriverNotFound":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(evt.Args[0] as string);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "OnDriverFoundSuccess":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(evt.Args[1] as string);
                        Console.ForegroundColor = ConsoleColor.White;
                        Report.Vehicle.Driver = evt.Args[0] as Driver;
                        success = true;
                        if (success)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The order is successful! Here your report.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(Report);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The order is not processed!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    }
                default:
                    break;
            }

            Report = new Report();
        }
    }
}
