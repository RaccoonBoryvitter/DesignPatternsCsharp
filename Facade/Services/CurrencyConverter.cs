using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Services
{
    internal class CurrencyConverter
    {
        public double FromUsdToUah(double money) =>
            money * 26.27;

        public double FromUahToUsd(double money) =>
            money / 26.27;

        public double FromEurToUah(double money) =>
            money * 30.59;

        public double FromUahToEur(double money) =>
            money / 30.59;

        // and so far and so on...
    }
}
