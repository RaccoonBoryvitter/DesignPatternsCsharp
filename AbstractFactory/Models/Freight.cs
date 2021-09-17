using AbstractFactory.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactory.Models
{
    internal class Freight
    {
        public string Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DeliverType DeliverType { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }

        private readonly List<string> cities = new List<string>
        {
            "Chernivsti", "Khmelnytskyi", "Lviv", "Ivano-Frankivsk",
            "Uzhgorod", "Odessa", "Dnipro", "Kharkiv"
        };

        public Freight(double weight, DeliverType deliverType, string description)
        {
            Id = Guid.NewGuid().ToString();
            From = ListRandomPicker.PickFromList(cities);
            To = ListRandomPicker.PickFromList(cities.Where(c => c != From).ToList());
            Weight = weight;
            DeliverType = deliverType;
            Description = description;
        }
    }
}
