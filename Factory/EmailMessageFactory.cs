using System;
using System.Collections.Generic;
using System.Text;
using Factory.Message;

namespace Factory
{
    public class EmailMessageFactory: MessageFactory
    {
        public override IMessage CreateMessage()
        {
            return new EmailMessage();
        }
    }
}
