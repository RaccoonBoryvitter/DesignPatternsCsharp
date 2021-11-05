using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class SecurityHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if((request as Freight).SecurityType == SecurityType.Danger)
            {
                var freight = request as Freight;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Freight {freight.Id} should be provided with extra security transportation.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return base.Handle(request);
        }
    }
}
