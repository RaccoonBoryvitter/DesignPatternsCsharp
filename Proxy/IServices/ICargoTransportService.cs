using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.IServices
{
    internal interface ICargoTransportService
    {
        CargoTransport GetById(Guid id);

        List<CargoTransport> All();

        void Insert(CargoTransport cargoTransport);

        void Update(CargoTransport cargoTransport);

        void Delete(CargoTransport cargoTransport);
    }
}
