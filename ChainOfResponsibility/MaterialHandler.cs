using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class MaterialHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            var freight = request as Freight;
            if (freight.MaterialType == MaterialType.Liquid)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Freight {freight.Id} should be carried in a tank.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (freight.MaterialType == MaterialType.Fragile)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Freight {freight.Id} should be carried in an anti-shaking wrapper.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return base.Handle(request);
        }
    }
}
