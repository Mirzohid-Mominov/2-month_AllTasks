using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket_HT
{
    public class MillyHumo : IDebitCard
    {
        public string CardNumber { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public MillyHumo(string cardNumber, string bankName, double balance)
        {
            CardNumber = cardNumber;
            BankName = bankName;
            Balance = balance;
        }      
    }
}
