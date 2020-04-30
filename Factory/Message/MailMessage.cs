using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Message
{
    public class MailMessage: IMessage
    {
        public void Send()
        {
            Console.WriteLine("Отправлено сообщение машиной через почту");
        }
    }
}
