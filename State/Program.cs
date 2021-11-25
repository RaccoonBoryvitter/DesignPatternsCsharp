using State.Entity;
using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client
            {
                Id = Guid.NewGuid(),
                Name = "First",
                City = "Chernivtsi",
            };

            Client client2 = new Client
            {
                Id = Guid.NewGuid(),
                Name = "Second",
                City = "Sokyryany",
            };

            Order order1 = new Order(client1, 25.0, "Desc 1", new InitialOrderState());
            Order order2 = new Order(client1, 38.0, "Desc 2", new InitialOrderState());

            order1.MoveForward();
            order1.MoveForward();
            order1.MoveForward();

            Console.WriteLine();

            order2.MoveForward();
            order2.MoveForward();
            order2.MoveForward();
        }
    }
}