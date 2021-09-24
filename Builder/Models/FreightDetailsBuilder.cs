using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    internal class FreightDetailsBuilder : IFreightBuilder
    {
        private FreightDetails _freightDetails;

        public FreightDetailsBuilder() => Reset();

        public void Reset() => _freightDetails = new FreightDetails();

        public IFreightBuilder SetDescription(string description)
        {
            _freightDetails.Description = description;
            _freightDetails.Description += "\n\tFreight details are created to provide an information about freight for report issues.";
            return this;
        }

        public IFreightBuilder SetDispatchedAt(DateTime dispatchedAt)
        {
            _freightDetails.DispatchedAt = dispatchedAt;
            return this;
        }

        public IFreightBuilder SetFreightType(FreightType freightType)
        {
            _freightDetails.FreightType = freightType;
            return this;
        }

        public IFreightBuilder SetId(string id)
        {
            _freightDetails.Id = id;
            return this;
        }

        public IFreightBuilder SetReceiver(Company receiver)
        {
            _freightDetails.Receiver = receiver;
            return this;
        }

        public IFreightBuilder SetSender(Company sender)
        {
            _freightDetails.Sender = sender;
            return this;
        }

        public IFreightBuilder SetVolume(double volume)
        {
            _freightDetails.Volume = volume;
            return this;
        }

        public IFreightBuilder SetWeight(double weight)
        {
            _freightDetails.Weight = weight;
            return this;
        }

        public FreightDetails Build() => _freightDetails;
    }
}
