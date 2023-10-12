using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket_HT
{
    internal class PaymePaymentProvider : IPaymentProvider
    {
        public double TransferInterest { get; init; } = 0.3;

        public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {
            var AmountWithTransferinterest = amount + (amount / 100 *  TransferInterest);
            if(AmountWithTransferinterest > sourceCard.Balance)     return false;
            sourceCard.Balance -= AmountWithTransferinterest;
            destinationCard.Balance += amount;

            return true;
        }
    }
}
