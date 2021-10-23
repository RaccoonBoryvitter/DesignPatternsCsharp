using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Services
{
    internal class MassConverter
    {
        public double FromKgToLbs(double mass) =>
            mass / 0.45359237;

        public double FromLbsToKg(double mass) =>
            mass * 0.45359237;

        public double FromGramsToOunces(double mass) =>
            mass / 28.34952;

        public double FromOuncesToGrams(double mass) =>
            mass * 28.34952;

        public double FromGramsToKgs(double mass) =>
            mass * 1000;

        // and so far and so on...
    }
}
