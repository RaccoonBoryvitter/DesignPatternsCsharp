using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Command
{
    internal class Warehouse
    {
        public ICommand OnDayStart { get; set; }

        public ICommand OnDayFinish { get; set; }

        public void ProcessDayWork()
        {
            OnDayStart.Execute();

            Thread.Sleep(2000);
            Console.WriteLine("A work day later...");

            OnDayFinish.Execute();
        }
    }
}
