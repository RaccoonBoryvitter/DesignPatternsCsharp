using AbstractFactory.Helpers;
using AbstractFactory.Models.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbstractFactory.Models
{
    internal class Company
    {
        private readonly List<ITransport> transportInfrastructure = new List<ITransport>();
        public List<Freight> Freights { get; set; }


        public LogisticsFactory LogisticsFactory { get; set; }

        public Company(LogisticsFactory logisticsFactory)
        {
            LogisticsFactory = logisticsFactory
                               ?? throw new ArgumentNullException(nameof(logisticsFactory));
        }

        public void RunDeliveryThreads()
        {
            int regular = Freights.Where(f => f.DeliverType == DeliverType.Regular).Count();
            for (int i = 0; i < regular; i++)
                LogisticsFactory.RegisterNewRegularVehicle();

            int urgent = Freights.Where(f => f.DeliverType == DeliverType.Urgent).Count();
            for (int i = 0; i < urgent; i++)
                LogisticsFactory.RegisterNewUrgentVehicle();

            transportInfrastructure.AddRange(LogisticsFactory.RegularVehicles);
            transportInfrastructure.AddRange(LogisticsFactory.UrgentVehicles);
            List<Thread> threads = this.InitializeDeliveryThreads(Freights.Count);
            foreach (Thread t in threads)
            {
                ITransport vehicle = ListRandomPicker.PickFromList(transportInfrastructure);
                t.Start(vehicle);
                t.Join();
            }
        }

        private List<Thread> InitializeDeliveryThreads(int threadAmount)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < threadAmount; i++)
            {
                threads.Add(new Thread(new ParameterizedThreadStart(RunDelivery)));
            }

            return threads;
        }

        private void RunDelivery(object transport)
        {
            ITransport t = transport as ITransport;
            Freight freight = ListRandomPicker.PickFromList(Freights);
            if (freight.Weight <= t.WeightCapacity)
            {
                t.Deliver(freight);
            }
            else
            {
                Console.WriteLine("\nUnable to deliver this cargo: too much weight!\n");
            }
        }
    }
}
