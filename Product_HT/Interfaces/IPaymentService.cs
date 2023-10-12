using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PaymentService dan foydalaning 
//- Checkout ( amount, debitCard ) -agar kartada yetarli miqdorda pul bo'lsa minus qilib, true qaytarsin, bo'lmasa false

//PaymentService da IPaymentService ni implement qiling

//IOrderService dan foydalaning - bunda ProductService va PaymentService composition qilib ishlatilsin
//- Order ( id, card ) -bitta mahsulot xarid qilish
//- Order ( filterModel, card ) -bir nechta mahsulot har qilish 



namespace Product_HT.Interfaces
{
    interface IPaymentService
    {
        public bool Checkout(double amount, DebitCard debitcard);
    }
}
