using Microrabbit.banking.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.banking.domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    
    }
    
}
