using System;
using AbstractFactory.Models.Transport;

namespace AbstractFactory.Models.Logistics
{
    internal class TruckFactory : LogisticsFactory
    {
        public override ITransport CreateRegularVehicle()
        {
            return new RegularTrack();
        }

        public override ITransport CreateUrgentVehicle()
        {
            return new UrgentTrack();
        }
    }
}
