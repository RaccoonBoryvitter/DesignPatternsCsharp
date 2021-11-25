using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entity
{
    internal class ProcessingOrderState : OrderState
    {
        public override void MoveForward()
        {
            if(Order.Weight <= OrderConstants.MaxWeight)
            {
                Console.WriteLine($"The order #{Order.Id} has been marked as Ready.");
                Order.MoveTo(new ReadyOrderState());
            } 
            else
            {
                MoveBackward();
            }
        }

        public override void MoveBackward()
        {
            Console.WriteLine($"The order #{Order.Id} has been returned to client.");
            Order.MoveTo(new InitialOrderState());
        }
    }
}
