using Mediator.MediatR;
using System;
using System.Collections.Generic;

namespace Mediator.Entity
{
    internal class Client : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public void OrderDispatch(Freight freight, Client to)
        {
            Console.WriteLine($"I want you to dispatch freight #{freight.Id} to {to.Name}.");
            EventComponent evt = new EventComponent("OnDispatchOrder", freight, to);
            Mediator.Notify(this, evt);
        }

        public override string ToString()
        {
            return $" - Name: {Name};\n - Address: {Address};\n";
        }
    }
}
