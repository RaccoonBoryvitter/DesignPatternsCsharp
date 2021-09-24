using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    internal class FreightDetails
    {
        public string Id { get; set; }
        public Company Sender { get; set; }
        public Company Receiver { get; set; }
        public FreightType FreightType { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public string Description { get; set; }
        public DateTime DispatchedAt { get; set; }

        public override string ToString()
        {
            string info = $"\n + Identification number: {Id}"
                        + $"\n + Sender Company Details: "
                        + $"\n\t - Sender Company ID: {Sender.Id}"
                        + $"\n\t - Sender Company Name: {Sender.Name}"
                        + $"\n\t - Sender Company Location: {Sender.Location}"
                        + $"\n + Receiver Company Details: "
                        + $"\n\t - Receiver Company ID: {Receiver.Id}"
                        + $"\n\t - Receiver Company Name: {Receiver.Name}"
                        + $"\n\t - Receiver Company Location: {Receiver.Location}"
                        + $"\n + Freight Type: {Enum.GetName(FreightType.GetType(), FreightType)}"
                        + $"\n + Weight: {Weight}"
                        + $"\n + Volume: {Volume}"
                        + $"\n + Description: \n\t{Description}"
                        + $"\n + Dispatched at: {DispatchedAt}";

            return info;
        }
    }
}
