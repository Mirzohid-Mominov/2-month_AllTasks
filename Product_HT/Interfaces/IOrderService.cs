using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IOrderService dan foydalaning - bunda ProductService va PaymentService composition qilib ishlatilsin
//- Order ( id, card ) -bitta mahsulot xarid qilish
//- Order ( filterModel, card ) -bir nechta mahsulot har qilish 

//OrderService da IOrderService ni implement qiling

namespace Product_HT.Interfaces
{
    interface IOrderService
    {
        public bool Order(Guid id, DebitCard card);
        public bool Order(ProductFilterDataModel filterModel, DebitCard card);

    }
}
