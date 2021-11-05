using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if(_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Processing has been completed!");
                Console.ForegroundColor = ConsoleColor.White;
                return null;
            }
        }
    }
}
