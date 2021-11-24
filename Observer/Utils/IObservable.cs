using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Utils
{
    internal interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify(object data);
    }
}
