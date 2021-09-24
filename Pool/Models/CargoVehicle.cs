using Pool.Helpers;
using System;
using System.Threading;

namespace Pool.Models
{
    internal class CargoVehicle
    {
        public int Rfid { get; set; }
        public double WeightCapacity { get; set; }
        public DateTime LifeTime { get; set; }


        public CargoVehicle()
        {
            Rfid = new Random().Next(832) + 1;
            WeightCapacity = new Random().NextDouble() * 20.0 + 10.0;
            LifeTime = DateRangePicker.PickBetween("01-01-2023", "31-12-2045");
            Console.WriteLine($"#############################################################"
                            + $"\nTransport #{Rfid} has been created.\n"
                            + $"\n#############################################################");
        }
        public void Deliver(Freight freight)
        {
            Thread.Sleep(500);
            Console.WriteLine($"//////////////////////////////////////////////////////////////"
                            + $"\nA freight #{freight.Id} has been delivered successfully from {freight.From} to {freight.To}."
                            + $"\nDelivered by: {Rfid}."
                            + $"\n//////////////////////////////////////////////////////////////\n");
        }
    }
}
