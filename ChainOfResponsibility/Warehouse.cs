using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    internal class Warehouse
    {
        public List<Freight> Freights { get; }

        public Warehouse(List<Freight> freights)
        {
            Freights = freights;
        }

        public IEnumerable<Shipment> ProcessFreights(AbstractHandler handler)
        {
            var shipments = new List<Shipment>();
            foreach (var freight in Freights)
            {
                var shipment = handler.Handle(freight);
                if (shipment != null)
                {
                    shipments.Add(shipment as Shipment);
                }
                else
                {
                    continue;
                }
            }

            return shipments;
        }
    }
}
