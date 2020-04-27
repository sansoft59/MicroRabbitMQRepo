using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.banking.domain.Models
{
    public class Account
    {
        public int id { get; set; }
        public string AccountType { get; set; }

        public decimal AccountBalance { get; set; }
    }
}
