using Adapter.Services;

namespace Adapter.Models
{
    internal class ForeignToLocalFreightAdapter : Freight
    {
        private readonly ForeignShipment _shipment;

        public ForeignToLocalFreightAdapter(ForeignShipment shipment)
        {
            _shipment = shipment;
        }

        public override string GetInfo()
        {
            string info = $"\n + Identification number: {_shipment.Id}"
                        + $"\n + From: {_shipment.From}"
                        + $"\n + To: {To}"
                        + $"\n + Weight: {ConverterService.ConvertLbToKg(_shipment.Weight)} kg"
                        + $"\n + Description: \n\t{_shipment.Description}";

            return info;
        }
    }
}
