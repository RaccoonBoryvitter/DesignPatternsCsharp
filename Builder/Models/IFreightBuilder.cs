using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    internal interface IFreightBuilder
    {
        void Reset();
        IFreightBuilder SetId(string id);
        IFreightBuilder SetSender(Company sender);
        IFreightBuilder SetReceiver(Company receiver);
        IFreightBuilder SetFreightType(FreightType freightType);
        IFreightBuilder SetWeight(double weight);
        IFreightBuilder SetVolume(double volume);
        IFreightBuilder SetDescription(string description);
        IFreightBuilder SetDispatchedAt(DateTime dispatchedAt);
    }
}
