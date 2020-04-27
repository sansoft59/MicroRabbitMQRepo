using Microrabbit.banking.domain.Interfaces;
using Microrabbit.banking.domain.Models;
using Microrabbit.Banking.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Application.Services
{
    public class AccountServices : IAccountServices
    {

        private readonly IAccountRepository _accountrepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountrepository = accountRepository;
        }
       
        
        
        public IEnumerable<Account> GetAccounts()
        {
            return _accountrepository.GetAccounts();
        }
    }
}
