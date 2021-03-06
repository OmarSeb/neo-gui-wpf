﻿namespace Neo.Gui.Base.Messaging.Interfaces
{
    public interface IInternalMessageAggregator
    {
        void Subscribe(IMessageHandler messageHandler);

        void Unsubscribe(IMessageHandler messageHandler);

        void Publish<T>(T message);
    }
}
