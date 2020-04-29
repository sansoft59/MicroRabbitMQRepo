using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microrabbit.banking.domain.Models;
using Microrabbit.Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Microrabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountServices _accountService;

        public BankingController(IAccountServices accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

    }
}
