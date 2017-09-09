﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MessageDispatcher
{
    public interface IMessageBroker : IDisposable
    {
        void Publish<T>(object source, T message);
        void Subscribe<T>(Action<MessagePayload<T>> subscription);
        void Unsubscribe<T>(Action<MessagePayload<T>> subscription);
    }

}
