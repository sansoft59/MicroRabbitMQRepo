﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Domain.Core.Bus
{
   public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;

        void Subscriber<T, Th>() where T : Event
            where Th : IEventHandler<T>;
    }
}
