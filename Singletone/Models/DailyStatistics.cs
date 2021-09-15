using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    internal sealed class DailyStatistics
    {
        public int Deliveries { get; set; }
        public int Dispatches { get; set; }
        public double TotalDeliveriesWeight { get; set; }
        public double TotalDispatchesWeight { get; set; }

        private DailyStatistics() { }

        public static DailyStatistics Instance => InstanceHolder._instance;

        private class InstanceHolder
        {
            static InstanceHolder() { }

            internal static readonly DailyStatistics _instance = new DailyStatistics();
        }

        public void IncrementDeliveriesAmount() => Deliveries++;
        public void IncrementDispatchesAmount() => Dispatches++;
        public void IncreaseDeliveriesWeight(double weight) => TotalDeliveriesWeight += weight;
        public void IncreaseDispatchesWeight(double weight) => TotalDispatchesWeight += weight;

        public void Reset()
        {
            Deliveries = 0;
            Dispatches = 0;
            TotalDeliveriesWeight = 0.0;
            TotalDispatchesWeight = 0.0;
            Console.WriteLine("\nStatistics are empty for now!\n");
        }

        public string GetInfo()
        {
            string info = "========================== OVERALL ===========================\n"
                + " + Total deliveries: " + Deliveries + ";\n"
                + " + Total dispatches: " + Dispatches + ";\n"
                + " + Deliveries weight: " + TotalDeliveriesWeight + ";\n"
                + " + Dispatches weight: " + TotalDispatchesWeight + ";\n"
                + "================================================================\n";

            return info;
        }
    }
}
