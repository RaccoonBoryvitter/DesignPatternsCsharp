using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mediator.MediatR
{
    internal class EventComponent
    {
        public string Type { get; set; }

        public object[] Args { get; set; }

        public EventComponent(string type, params object[] args)
        {
            Type = type;
            Args = args;
        }
    }
}
