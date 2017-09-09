using System;

namespace MessageDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MessageBroker bus = MessageBroker.Instance;
            CreateCustomerMessage cm = new CreateCustomerMessage();
            cm.Custommessage = "This is my custom message";
            MessagePayload<CreateCustomerMessage> messagePayload = new MessagePayload<CreateCustomerMessage>(new CreateCustomerMessage(),new CustomerCreator() );
            bus.Subscribe<CreateCustomerMessage>(i => new CreateCustomerhandler(messagePayload));
            bus.Publish<CreateCustomerMessage>(new CustomerCreator(),cm );
            Console.ReadLine();
            
        }
    }
}
