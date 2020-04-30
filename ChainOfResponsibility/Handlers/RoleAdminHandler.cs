using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handlers
{
    public class RoleAdminHandler: Handler
    {
        public override bool Check(object request)
        {
            return ((UserRequest) request).IsAdmin && base.Check(request);
        }
    }
}
