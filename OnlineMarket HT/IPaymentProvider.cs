using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IPaymentProvider interfeysidan foydalaning

//unda quyidagi methodlar bo'lsin
//- Transfer ( sourceCard, destinationCard, amount ) -pulni bir kartadan ikkinchi kartaga o'tkazsin

//unda quyidagi propertylar bo'lsin
//- TransferInterest ( init-only ) -har bitta trazaksiya uchun yechib olinadigan foiz 


namespace OnlineMarket_HT
{
    internal interface IPaymentProvider
    {
        public double TransferInterest { get; init; }

        public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);


    }
}
