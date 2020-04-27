using Microrabbit.banking.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Application.Interfaces
{
    public interface IAccountServices
    {
        IEnumerable<Account> GetAccounts();
    }
}
