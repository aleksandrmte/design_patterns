using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class AuthHandler: Handler
    {
        public override bool Check(object request)
        {
            return ((UserRequest) request).IsAuth && base.Check(request);
        }
    }
}
