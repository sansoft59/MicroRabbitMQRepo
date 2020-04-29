using Microrabbit.banking.domain.Interfaces;
using Microrabbit.Banking.Application.Interfaces;
using Microrabbit.Banking.Application.Services;
using Microrabbit.Banking.Data.Context;
using Microrabbit.Banking.Data.Repository;
using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using RabbitMqInfraBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IOC
{
   public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddTransient<IEventBus, RabbitMQInfraBus>();
            service.AddTransient<IAccountServices, AccountServices>();
            service.AddTransient<IAccountRepository, AccountRepository>();
            service.AddTransient<BankingDbContext>();
        }

    }
}
