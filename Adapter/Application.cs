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

            ForeignCargoVehicle vehicle1 = new ForeignCargoVehicle();
            ForeignCargoVehicle vehicle2 = new ForeignCargoVehicle();
            LocalCargoVehicle vehicle3 = new LocalCargoVehicle();
            LocalCargoVehicle vehicle4 = new LocalCargoVehicle();

            vehicle1.Deliver(shipment1);
            vehicle2.Deliver(shipment2);

            Freight freight1 = new ForeignToLocalFreightAdapter(shipment1);
            freight1.To = ListRandomPicker.PickFromList(cities);
            Freight freight2 = new ForeignToLocalFreightAdapter(shipment2);
            freight2.To = ListRandomPicker.PickFromList(cities);

            vehicle3.Deliver(freight1);
            vehicle4.Deliver(freight2);
    }
    }
}
