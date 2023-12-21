using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApi.Repository
{
    public class BankAplication
    {
        public decimal AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public void MakeDeposit()
        {

        }
        public void WithdrawMoney()
        {

        }

        public decimal GetBalance() =>  this.Balance;
    }
}
