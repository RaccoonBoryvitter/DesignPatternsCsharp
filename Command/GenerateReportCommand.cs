using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class GenerateReportCommand : ICommand
    {
        public Freight Freight { get; set; }

        public GenerateReportCommand(Freight freight)
        {
            Freight = freight;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Freight info: ");
            Console.WriteLine($" - ID: {Freight.Id},");
            Console.WriteLine($" - Weight: {Freight.Weight},");
            Console.WriteLine($" - Description: {Freight.Description}.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
