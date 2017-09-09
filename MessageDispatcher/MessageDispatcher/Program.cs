using System;

namespace MessageDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MessageBroker bus = MessageBroker.Instance;
            MessagePayload<CreateCustomerMessage> messagePayload = new MessagePayload<CreateCustomerMessage>(new CreateCustomerMessage(),new CustomerCreator() );
            bus.Subscribe<CreateCustomerMessage>(i => new CreateCustomerhandler(messagePayload));
            bus.Publish<CreateCustomerMessage>(new CustomerCreator(), new CreateCustomerMessage());
            Console.ReadLine();
            
        }
    }
}
