using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    internal interface CargoVehicle
    {
        Guid Rfid { get; set; }
        double Speed { get; set; }

        void Deliver(Freight freight);
    }
}
