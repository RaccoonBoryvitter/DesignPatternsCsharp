using FactoryMethod.Models.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models.Logistics
{
    internal class TruckDepartment : LogisticsDepartment
    {
        public override CargoVehicle CreateVehicle()
        {
            return new CargoTruck();
        }
    }
}
