using Observer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Utils
{
    internal class Logistics
    {
        public List<Division> Divisions { get; set; }

        public Logistics(List<Division> divisions)
        {
            Divisions = divisions;
        }

        public void MakeOrder(Order order)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hey, {order.Client.Name} wants to make an order!");
            Console.ForegroundColor = ConsoleColor.White;
            Divisions.Where(d => d.City == order.Client.City).ToList().ForEach(d => d.Notify(order));
        }
        
    }
}
