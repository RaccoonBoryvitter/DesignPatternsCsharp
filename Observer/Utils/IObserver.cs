using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Utils
{
    internal interface IObserver
    {
        void Update(object data);
    }
}
