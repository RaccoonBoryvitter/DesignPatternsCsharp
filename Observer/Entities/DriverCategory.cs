using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Entities
{
    internal class DriverCategory
    {

        public string Title { get; private set; }

        private DriverCategory(string title) { Title = title; }

        public static DriverCategory C => new DriverCategory("C");
        public static DriverCategory C_E => new DriverCategory("C-E");
        public static DriverCategory C1 => new DriverCategory("C1");
        public static DriverCategory C1_E => new DriverCategory("C1-E");

    }
}
