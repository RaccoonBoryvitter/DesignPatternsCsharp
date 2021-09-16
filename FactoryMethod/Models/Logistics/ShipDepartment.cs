using FactoryMethod.Models.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models.Logistics
{
    internal class ShipDepartment : LogisticsDepartment
    {
        public override CargoVehicle CreateVehicle()
        {
            return new CargoShip();
        }
    }
}
