using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entity
{
    internal class Order
    {
        public Guid Id { get; set; }

        public Client Client { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }

        public OrderState State { get; set; }

        public Order(
            Client client, 
            double weight, 
            string description, 
            OrderState state)
        {
            Id = Guid.NewGuid();
            Client = client;
            Weight = weight;
            Description = description;

            State = state;
            State.Order = this;
        }

        public void MoveTo(OrderState state)
        {
            State = state;
            State.Order = this;
        }

        public void MoveForward() => State.MoveForward();
        public void MoveBackward() => State.MoveBackward();
    }
}
