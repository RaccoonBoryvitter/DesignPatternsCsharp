using Mediator.MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Entity
{
    internal class Logistics : BaseEntity
    {
        public AppDbContext DbContext { get; set; }

        public void FindVehicle(Freight freight)
        {
            var vehicle = DbContext.Vehicles.FirstOrDefault(v => v.WeightCapacity >= freight.Weight);

            if(vehicle == null)
            {
                string msg = "ERROR! All vehicles are busy now!";
                EventComponent evt = new EventComponent("OnVehicleNotFound", msg);
                Mediator.Notify(this, evt);
            }
            else
            {
                string msg = "The vehicle has been found!";
                EventComponent evt = new EventComponent("OnVehicleFoundSuccess", vehicle, msg);
                DbContext.Vehicles.Remove(vehicle);
                Mediator.Notify(this, evt);
            }
        }

        public void FindDriver()
        {
            var driver = DbContext.Drivers.FirstOrDefault();

            if (driver == null)
            {
                string msg = "ERROR! All drivers are busy now!";
                EventComponent evt = new EventComponent("OnDriverNotFound", msg);
                Mediator.Notify(this, evt);
            }
            else
            {
                string msg = "The driver has been found! Assigning vehicle to him...";
                DbContext.Drivers.Remove(driver);
                EventComponent evt = new EventComponent("OnDriverFoundSuccess", driver, msg);
                Mediator.Notify(this, evt);
            }
        }
    }
}
