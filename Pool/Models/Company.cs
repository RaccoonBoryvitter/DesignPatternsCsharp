using Pool.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pool.Models
{
    class Company
    {
        private ObjectPool<CargoVehicle> transportInfrastructure;
        public List<Freight> Freights { get; set; }

        public Company()
        {
            transportInfrastructure = new ObjectPool<CargoVehicle>(() => new CargoVehicle());

        }

        public void RunDeliveryThreads(int threadAmount)
        {
            List<Thread> threads = this.InitializeDeliveryThreads(threadAmount);
            foreach (Thread t in threads)
            {
                CargoVehicle vehicle = transportInfrastructure.Get();
                t.Start(vehicle);
            }

            foreach (Thread t in threads)
            {
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
            v.Deliver(freight);
            transportInfrastructure.Return(v);
        }

    }
}
