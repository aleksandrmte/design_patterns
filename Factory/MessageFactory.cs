using Factory.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class MessageFactory
    {
        public void Send()
        {
            var message = CreateMessage();
            message.Send();
        }
        public abstract IMessage CreateMessage();
    }
}
