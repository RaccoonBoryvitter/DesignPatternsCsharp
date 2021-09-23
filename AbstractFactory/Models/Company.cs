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
        public List<Freight> CurrentFreights { get; set; }


        public LogisticsFactory LogisticsFactory { get; set; }

        public Company(LogisticsFactory logisticsFactory)
        {
            LogisticsFactory = logisticsFactory
                               ?? throw new ArgumentNullException(nameof(logisticsFactory));
        }

        public void RunDeliveryThreads()
        {
            DeliverType deliverType = LogisticsFactory is RegularDeliveryFactory ? DeliverType.Regular : DeliverType.Urgent;
            CurrentFreights = Freights.Where(f => f.DeliverType == deliverType).ToList();
            int deliveriesAmount = CurrentFreights.Count();
            int trucksAmount = new Random().Next(deliveriesAmount) + 1;
            for (int i = 0; i < trucksAmount; i++)
                LogisticsFactory.RegisterNewTruck();

            int shipAmount = deliveriesAmount - trucksAmount;
            for (int i = 0; i < shipAmount; i++)
                LogisticsFactory.RegisterNewShip();

            transportInfrastructure.Clear();
            transportInfrastructure.AddRange(LogisticsFactory.Trucks);
            transportInfrastructure.AddRange(LogisticsFactory.Ships);
            List<Thread> threads = this.InitializeDeliveryThreads(deliveriesAmount);
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
            Freight freight = ListRandomPicker.PickFromList(CurrentFreights);
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
