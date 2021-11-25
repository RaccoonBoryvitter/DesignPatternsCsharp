using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entity
{
    internal class ReadyOrderState : OrderState
    {
        public override void MoveForward()
        {
            Console.WriteLine($"The order #{Order.Id} is ready for dispatch.");
        }

        public override void MoveBackward()
        {
            Console.WriteLine($"The order #{Order.Id} needs an additional processing. Moving it back.");
            Order.MoveTo(new ProcessingOrderState());
        }
    }
}
