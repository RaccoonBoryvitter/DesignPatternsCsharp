using System;
using System.Collections.Generic;
using Mediator.MediatR;

namespace Mediator.Entity
{
    internal class BaseEntity
    {
        public IMediatR Mediator { get; set; }

        public BaseEntity(IMediatR mediator = null)
        {
            Mediator = mediator;
        }
    }
}
