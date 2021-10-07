using Adapter.Models;
using Adapter.Services;
using System;
using System.Collections.Generic;

namespace Adapter
{
    internal class Application
    {
        internal static void Main(string[] args)
        {
            List<string> cities = new List<string>()
            {
                "Chernivsti", "Khmelnytskyi", "Lviv", "Ivano-Frankivsk", "Uzhgorod", "Odessa", "Dnipro", "Kharkiv"
            };

            ForeignShipment shipment1 = new ForeignShipment(1350, "Shipment #1");
            ForeignShipment shipment2 = new ForeignShipment(1530, "Shipment #2");

            CargoVehicle vehicle1 = new CargoVehicle();
            CargoVehicle vehicle2 = new CargoVehicle();
            CargoVehicle vehicle3 = new CargoVehicle();
            CargoVehicle vehicle4 = new CargoVehicle();

            vehicle1.ForeignDeliver(shipment1);
            vehicle2.ForeignDeliver(shipment2);

            Freight freight1 = new ForeignToLocalFreightAdapter(shipment1);
            freight1.To = ListRandomPicker.PickFromList(cities);
            Freight freight2 = new ForeignToLocalFreightAdapter(shipment2);
            freight2.To = ListRandomPicker.PickFromList(cities);

            vehicle3.LocalDeliver(freight1);
            vehicle4.LocalDeliver(freight2);
    }
    }
}
