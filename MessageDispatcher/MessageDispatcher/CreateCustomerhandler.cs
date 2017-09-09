using System;
using System.Collections.Generic;
using System.Text;

namespace MessageDispatcher
{
    class CreateCustomerhandler
    {
        public CreateCustomerhandler()
        {
            Console.WriteLine("plain CTOR -- Handling Customer Creation");
        }
        public CreateCustomerhandler(MessagePayload<CreateCustomerMessage> messagePayload)
        {
            Console.WriteLine("parameterized CTOR -- Handling Customer Creation");
        }
        public void handle(MessagePayload<CreateCustomerMessage> messagePayload, string str)
        {
            Console.WriteLine("Handling Customer Creation");
        }
    }
}
