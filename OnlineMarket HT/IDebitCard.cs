using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IDebitCard interfeysidan foydalaning

//unda quyidagi propertylar bo'lsin
//- CardNumber - karta raqami
//- BankName - bank nomi ( init only )
//-Balance - hozirgi kartadagi balans

//quyidagi modellar IDebitCard ni implement qilgan bo'lsin

//- KapitalUzcard
//- MillyHumo


namespace OnlineMarket_HT
{
     interface IDebitCard
    {
        public string CardNumber { get; set; }  
        public string BankName { get; set; }
        public double Balance { get; set; }
    }
}
