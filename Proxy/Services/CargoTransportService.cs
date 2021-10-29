using Proxy.Database;
using Proxy.IServices;
using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy.Services
{
    internal class CargoTransportService : ICargoTransportService
    {
        public DbContext Context { get; set; }

        public CargoTransportService(DbContext context)
        {
            Context = context;
        }

        public List<CargoTransport> All()
        {
            return Context.Transports;
        }

        public void Delete(CargoTransport cargoTransport)
        {
            Context.Transports.Remove(cargoTransport);
        }

        public CargoTransport GetById(Guid id)
        {
            return Context.Transports.FirstOrDefault(t => t.Id == id);
        }

        public void Insert(CargoTransport cargoTransport)
        {
            Context.Transports.Add(cargoTransport);
        }

        public void Update(CargoTransport cargoTransport)
        {
            var original = Context.Transports.FirstOrDefault(t => t.Id == cargoTransport.Id);
            if (original != null)
            {
                original = new CargoTransport
                {
                    Id = original.Id,
                    Name = cargoTransport.Name,
                    MaxSpeed = cargoTransport.MaxSpeed,
                    FuelCapacity = cargoTransport.FuelCapacity
                };
            }
        }

    }
}