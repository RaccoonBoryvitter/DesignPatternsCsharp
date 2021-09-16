using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Transport
{
    internal interface CargoVehicle
    {
        string Rfid { get; set; }
        double WeightCapacity { get; set; }
        DateTime LifeTime { get; set; }
        bool IsInTheWay { get; set; }

        void Deliver(Freight freight);
    }
}
