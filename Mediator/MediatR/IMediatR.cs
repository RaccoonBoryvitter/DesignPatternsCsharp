using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.MediatR
{
    interface IMediatR
    {
        void Notify(object sender, EventComponent evt);
    }
}
