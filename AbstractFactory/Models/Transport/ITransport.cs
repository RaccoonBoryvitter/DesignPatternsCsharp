using System;

namespace AbstractFactory.Models
{
    internal interface ITransport
    {
        string Rfid { get; set; }
        double WeightCapacity { get; set; }
        DateTime LifeTime { get; set; }
        bool IsInTheWay { get; set; }

        void Deliver(Freight freight);
    }
}
