using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entity
{
    internal class InitialOrderState : OrderState
    {
        public override void MoveForward()
        {
            Console.WriteLine($"The order #{Order.Id} has been sent on processing.");
            Order.MoveTo(new ProcessingOrderState());
        }

        public override void MoveBackward()
        {
            Console.WriteLine($"The order #{Order.Id} stills on initial state.");
        }
    }
}
