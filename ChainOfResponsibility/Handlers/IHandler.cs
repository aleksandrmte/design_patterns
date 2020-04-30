using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        bool Check(object request);
    }
}
