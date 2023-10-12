using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_HT.Interfaces;


//IProductService dan foydalaning 
//- Inventory - IProduct tipidagi kolleksiya
//- Add ( product ) -inventoryga product qo'shsin
//- GetFilterData - filter data model yasab qaytarsin, agar birorta produkt bo'lmasa filter model da empty value bo'lsin ( list uchun empty list )

//ProductService da IProductService ni imiplement qiling  

//- Get ( filterModel ) -filter bo'yicha topilgan produktlarni copy constructor orqali nusxasini qaytarsin 
//- Order ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = true qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception
//- Return ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = false qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception

namespace Product_HT.Services
{
    internal class ProductService : IProductService
    {
        private List<IProduct> _inventory { get; set; }

        public ProductService()
        {
            _inventory = new List<IProduct>();
        }

        public void Add(IProduct product)
        {
            _inventory.Add(product);
        }

        public ProductFilterDataModel GetFilterData() => new ProductFilterDataModel(_inventory);

        //- Get ( filterModel ) -filter bo'yicha topilgan produktlarni copy constructor orqali nusxasini qaytarsin 
        public List<IProduct> Get(ProductFilterDataModel filterDataModel)
        {
            var filter = _inventory.Where(item => filterDataModel.ProductTypes.Contains(item.GetType().FullName)).ToList();
            var filtered = new List<IProduct>(filter);
            return filtered;
        }

        //- Order ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = true qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception
        public IProduct Order(Guid productId)
        {
            var findProduct = _inventory.Find(product => product.Id == productId);
            findProduct.IsOrdered = true;

            return CopyProduct(findProduct) is null
            ? throw new Exception("Product not found")
            : CopyProduct(findProduct);

        }

        //- Return ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = false qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception

        public IProduct Return(Guid productId)
        {
            var findProduct = _inventory.Find(product => product.Id == productId);
            findProduct.IsOrdered = false;
            
            return CopyProduct(findProduct) is null
                ? throw new Exception("Product not found")
                : CopyProduct(findProduct);

        }

        private IProduct CopyProduct(IProduct product)
        {
            if(product is Monitor monitor)
            {
                var obj = new Product_HT.Monitor(monitor);
                return obj;
            }
            else if(product is Chair chair)
            {
                var obj = new Chair(chair);
                return obj;
            }

            else if(product is Laptop laptop)
            {
                var obj = new Laptop(laptop);
                return obj;
            }
            return null;
        }
    }
}
