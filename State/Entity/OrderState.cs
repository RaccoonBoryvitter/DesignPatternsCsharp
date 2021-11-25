using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entity
{
    internal abstract class OrderState
    {
        public Order Order { get; set; }

        public abstract void MoveForward();

        public abstract void MoveBackward();
    }
}
