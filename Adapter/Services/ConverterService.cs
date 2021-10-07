using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    internal static class ConverterService
    {
        public static double ConvertLbToKg(double weight)
        {
            return weight / 2.2046;
        }
    }
}
