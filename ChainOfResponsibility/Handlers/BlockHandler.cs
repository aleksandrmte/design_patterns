using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class BlockHandler:Handler
    {
        public override bool Check(object request)
        {
            return !((UserRequest) request).IsBlocked && base.Check(request);
        }
    }
}
