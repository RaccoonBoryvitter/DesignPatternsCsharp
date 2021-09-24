using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    internal class Freight
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
                        + $"\n + Sender Company Name: {Sender.Name}"
                        + $"\n + Receiver Company Name: {Receiver.Name}"
                        + $"\n + Freight Type: {Enum.GetName(FreightType.GetType(), FreightType)}"
                        + $"\n + Weight: {Weight}"
                        + $"\n + Volume: {Volume}"
                        + $"\n + Description: \n\t{Description}"
                        + $"\n + Dispatched at: {DispatchedAt}";

            return info;
        }
    }
}
