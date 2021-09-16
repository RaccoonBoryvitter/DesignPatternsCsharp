using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Helpers
{
    public class DateRangePicker
    {
        public static DateTime PickBetween(string from, string to)
        {
            Random rnd = new Random();
            var range = DateTime.Parse(to) - DateTime.Parse(from);
            var randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * range.Ticks));
            return DateTime.Parse(from) + randTimeSpan;
        }
    }
}
