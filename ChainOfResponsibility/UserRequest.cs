using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class UserRequest
    {
        public bool IsAuth { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsAdmin { get; set; }
    }
}
