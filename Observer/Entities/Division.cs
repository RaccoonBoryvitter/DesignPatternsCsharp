using Observer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Entities
{
    internal class Division : IObservable
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(object data)
        {
            Observers.ForEach(o => o.Update(data));
        }
    }
}
