using Factory.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class MailMessageFactory: MessageFactory
    {
        public override IMessage CreateMessage()
        {
            return new MailMessage();
        }
    }
}
