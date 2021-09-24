using System;

namespace Builder.Models
{
    internal class FreightBuilder : IFreightBuilder
    {
        private Freight _freight;

        public FreightBuilder() => Reset();

        public void Reset() => _freight = new Freight();

        public IFreightBuilder SetDescription(string description)
        {
            _freight.Description = description;
            _freight.Description += "\n\tThis freight is real and probably in the road.";
            return this;
        }

        public IFreightBuilder SetDispatchedAt(DateTime dispatchedAt)
        {
            _freight.DispatchedAt = dispatchedAt;
            return this;
        }

        public IFreightBuilder SetFreightType(FreightType freightType)
        {
            _freight.FreightType = freightType;
            return this;
        }

        public IFreightBuilder SetId(string id)
        {
            _freight.Id = id;
            return this;
        }

        public IFreightBuilder SetReceiver(Company receiver)
        {
            _freight.Receiver = receiver;
            return this;
        }

        public IFreightBuilder SetSender(Company sender)
        {
            _freight.Sender = sender;
            return this;
        }

        public IFreightBuilder SetVolume(double volume)
        {
            _freight.Volume = volume;
            return this;
        }

        public IFreightBuilder SetWeight(double weight)
        {
            _freight.Weight = weight;
            return this;
        }

        public Freight Build() => _freight;
    }
}