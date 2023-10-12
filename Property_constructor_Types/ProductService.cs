using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- Product modelidan bir nechta object yarating ( valid va invalid )
//-Singleton pattern ishlatilgan ProductService ni yarating
//- unda Add methodi bo'lsin ( name, description ), agar product yaratishda exception bo'lsa konsolga exception chiqsin
//- unda Clone methodi bo'lsin ( id ) - u product ni topib, copy qilinganini kolleksiyaga qo'shib qo'ysin
//- unda Display methodi hamma productlarni ekranga chiqarsin

//- ProductService dan instance oling, valid invalid modellar qo'shib, Clone methodi orqali clonelar qilib, ekranga chiqaring


namespace Property_constructor_Types
{
    internal class ProductService
    {

        private static ProductService _instance;
        private List<Product> _products = new List<Product>()
        {
            new Product("hello", "Mother")
        };

        public static ProductService Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ProductService();
                return _instance;
            }
        }

        public Product Add(string name, string description)
        {
            try
            {
                var product = new Product(name, description);
                _products.Add(product);
                return product;
            }
            catch
            {
                throw new Exception("You can't add your product");
            }
        }

        public void Clone(Guid id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                var copy = new Product(product);
                _products.Add(copy);
            }
        }

        public void Display()
        {
            _products.ForEach(Console.WriteLine) ;
        }
    }
}
