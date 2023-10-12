using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IProductService dan foydalaning 
//- Inventory - IProduct tipidagi kolleksiya
//- Add ( product ) -inventoryga product qo'shsin
//- GetFilterData - filter data model yasab qaytarsin, agar birorta produkt bo'lmasa filter model da empty value bo'lsin ( list uchun empty list )

namespace Product_HT.Interfaces
{
    interface IProductService
    {
        public void Add(IProduct product);

       
        
    }
}
