using Microrabbit.banking.domain.Interfaces;
using Microrabbit.banking.domain.Models;
using Microrabbit.Banking.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {

        private BankingDbContext ctr;

        public AccountRepository(BankingDbContext _ctor)
        {
            ctr =  _ctor;
        }




        public IEnumerable<Account> GetAccounts()
        {
            return ctr.Accounts;
        }
    }
}
