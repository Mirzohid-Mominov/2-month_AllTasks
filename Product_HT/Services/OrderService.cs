using Product_HT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IOrderService dan foydalaning - bunda ProductService va PaymentService composition qilib ishlatilsin
//- Order ( id, card ) -bitta mahsulot xarid qilish
//- Order ( filterModel, card ) -bir nechta mahsulot har qilish 

//OrderService da IOrderService ni implement qiling

namespace Product_HT.Services
{
    internal class OrderService : IOrderService
    {
        private ProductService _productService;
        private PaymentService _paymentService;

        public OrderService(ProductService productService, PaymentService paymentService)
        {
            _productService = productService;
            _paymentService = paymentService;
        }
        
        //- Order ( id, card ) -bitta mahsulot xarid qilish
        public bool Order(Guid id, DebitCard card)
        {
            var product = _productService.Order(id);
            
            if (product is null) return false;
            if (_paymentService.Checkout(product.Price, card)) return true;
            
            return false;
        }
        
        //- Order ( filterModel, card ) -bir nechta mahsulot har qilish 
        public bool Order(ProductFilterDataModel filterModel, DebitCard card)
        {
            var products = _productService.Get(filterModel);
            if(products.Count == 0) return false;

            if(_paymentService.Checkout(products.Sum(s => s.Price), card)) return true;
            return false;
        }
    }
}
