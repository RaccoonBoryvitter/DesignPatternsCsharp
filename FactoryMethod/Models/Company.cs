using FactoryMethod.Models.Logistics;
using FactoryMethod.Models.Transport;
using FactoryMethod.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace FactoryMethod.Models
{
    internal class Company
    {
        private List<CargoVehicle> transportInfrastructure = new List<CargoVehicle>();
        public List<Freight> Freights { get; set; }


        public LogisticsDepartment LogisticsDepartment { get; set; }

        public Company(LogisticsDepartment logisticsDepartment)
        {
            LogisticsDepartment = logisticsDepartment 
                               ?? throw new ArgumentNullException(nameof(logisticsDepartment));
        }

        public void RunDeliveryThreads(int threadAmount)
        {
            for (int i = 0; i < threadAmount; i++)
                LogisticsDepartment.RegisterNewVehicle();
            transportInfrastructure.AddRange(LogisticsDepartment.Vehicles);
            List<Thread> threads = this.InitializeDeliveryThreads(threadAmount);
            foreach (Thread t in threads)
            {
                CargoVehicle vehicle = ListRandomPicker.PickFromList(transportInfrastructure);
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

        private void RunDelivery(object vehicle)
        {
            CargoVehicle v = vehicle as CargoVehicle;
            Freight freight = ListRandomPicker.PickFromList(Freights);
            if (freight.Weight <= v.WeightCapacity)
            {
                v.Deliver(freight);
            }
            else
            {
                Console.WriteLine("\nUnable to deliver this cargo: too much weight!\n");
            }
        }
    }
}
