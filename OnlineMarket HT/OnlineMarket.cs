using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OnlineMarket servisidan foydalaning
//unda quyidagi konstruktor bo'lsin
//- OnlineMarket ( IPaymentProvider provider ) -bunda provider private readonly fieldga saqlansin

//unda quyidagi methodlar bo'lsin
//- Add ( product ) -productlar qatoriga berilgan productni qo'shsin ) 
//- Buy ( name, number, card ) -product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab, kartadan pul yechishni payment provider orqali amalga oshirsin


namespace OnlineMarket_HT
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private readonly IDebitCard _debitCard;
        private List<Product> _products;

        public OnlineMarket(IPaymentProvider provider, IDebitCard marketCard)
        {
            _provider = provider;
            _debitCard = marketCard;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public bool BuyProduct(string name, int number, IDebitCard card)
        {
            foreach(var item in _products)
            {
                if(item.Name == name)
                {
                    var price = item.Price * number;
                    return _provider.Transfer(sourceCard : card , destinationCard : _debitCard, amount : price);
                }
            }
            return false;
        }
    } 
}
