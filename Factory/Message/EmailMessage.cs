using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Message
{
    public class EmailMessage: IMessage
    {
        public void Send()
        {
            Console.WriteLine("Отправлено сообщение по электронной почте");
        }
    }
}
