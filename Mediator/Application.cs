using Mediator.Entity;
using Mediator.MediatR;
using System;

namespace Mediator
{
    class Application
    {
        static void Main(string[] args)
        {
            Freight freight1 = new Freight { Weight = 10, Description = "1" };
            Freight freight2 = new Freight { Weight = 5, Description = "2" };
            Freight freight3 = new Freight { Weight = 50, Description = "3" };

            Client client1 = new Client { Name = "Воробушки", Address = "Chernivtsi" };
            Client client2 = new Client { Name = "Братва", Address = "Khmelnytskyi" };
            Client client3 = new Client { Name = "Ноунеймы какие-то крч я не знаю", Address = "Ivano-Frankivsk" };

            Logistics logistics = new Logistics { DbContext = new AppDbContext() };

            new Manager(client1, logistics);
            client1.OrderDispatch(freight1, client2);

            new Manager(client2, logistics);
            client2.OrderDispatch(freight2, client3);

            new Manager(client3, logistics);
            client3.OrderDispatch(freight3, client2);
        }
    }
}
