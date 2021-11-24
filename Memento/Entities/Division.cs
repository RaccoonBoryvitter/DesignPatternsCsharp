using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Entities
{
    [Serializable]
    internal class Division
    {

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

    }
}
