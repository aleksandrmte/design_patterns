using System;
using Factory.Message;

namespace Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Отправить сообщение по электронной почте или письмом? (y - электронная почта; иначе письмо)");
                MessageFactory messageCreator;

                if (Console.ReadLine()?.ToLower() == "y")
                    messageCreator = new EmailMessageFactory();
                else
                    messageCreator = new MailMessageFactory();

                messageCreator.Send();
            }
        }
    }
}
