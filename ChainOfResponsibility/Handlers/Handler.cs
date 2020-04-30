using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public abstract class Handler: IHandler
    {
        private IHandler _handler;

        public IHandler SetNext(IHandler handler)
        {
            _handler = handler;
            return handler;
        }

        public virtual bool Check(object request)
        {
            return _handler == null || _handler.Check(request);
        }
    }
}
