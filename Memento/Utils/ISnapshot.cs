using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Utils
{
    internal interface ISnapshot
    {

        string Title { get; set; }

        DateTime Timestamp { get; set; }

    }
}
