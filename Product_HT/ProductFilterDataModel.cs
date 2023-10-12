using Product_HT.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ProductFilterDataModel modeldan foydalaning, unde quyidagi propertylar bo'lsin
//- ProductTypes - hozirda mavjud produkt tiplari unique qilib olingani ( IEnumerable<string>, bu collection.Select(item => item.GetType().FullName) qilib olinadi )

namespace Product_HT
{
    internal class ProductFilterDataModel
    {
        public IEnumerable<string> ProductTypes { get; set; }

        public ProductFilterDataModel(IEnumerable<IProduct> products)
        {
            ProductTypes = products.Select(item => item.GetType().FullName).Distinct();
        }
    }
}
