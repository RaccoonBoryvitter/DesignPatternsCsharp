using Mediator.Entity;
using System;

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
                        OnDispatchOrder(sender, evt);
                        Console.WriteLine("Finding vehicle for this task...");
                        Logistics.FindVehicle(Report.Freight);
                        break;
                    }
                case "OnVehicleNotFound":
                    {
                        OnVehicleNotFound(sender, evt);
                        break;
                    }
                case "OnVehicleFoundSuccess":
                    {
                        OnVehicleFoundSuccess(sender, evt);
                        Console.WriteLine("Finding driver...");
                        Logistics.FindDriver();
                        break;
                    }
                case "OnDriverNotFound":
                    {
                        OnDriverNotFound(sender, evt);
                        break;
                    }
                case "OnDriverFoundSuccess":
                    {
                        OnDriverFoundSuccess(sender, evt);
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

        private void OnDispatchOrder(object sender, EventComponent evt)
        {
            Console.WriteLine("Receiving new order...");
            Report.From = sender as Client;
            Report.Freight = evt.Args[0] as Freight;
            Report.To = evt.Args[1] as Client;
        }

        private void OnVehicleNotFound(object sender, EventComponent evt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(evt.Args[0] as string);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void OnVehicleFoundSuccess(object sender, EventComponent evt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(evt.Args[1] as string);
            Console.ForegroundColor = ConsoleColor.White;
            Report.Vehicle = evt.Args[0] as Vehicle;
        }

        private void OnDriverNotFound(object sender, EventComponent evt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(evt.Args[0] as string);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void OnDriverFoundSuccess(object sender, EventComponent evt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(evt.Args[1] as string);
            Console.ForegroundColor = ConsoleColor.White;
            Report.Vehicle.Driver = evt.Args[0] as Driver;
        }
    }
}
