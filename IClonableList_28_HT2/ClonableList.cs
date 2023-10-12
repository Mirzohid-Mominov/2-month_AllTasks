using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ClonableList<T> dan foydalaning 

//bunda 
//- List<T> dan inheritance oling
//- ICloneable interfeysini implement qiling
//- T ga ICloneable constraint qo'llang

//StorageFile modelidan foydalaning ( id, name, description, size ), unda ICloneable ni implement qiling

//- dasturda ClonableList dan bitta object oling, ichiga bir nechta StorageFile objectlar qo'shing
//- list dan clone oling va deep copy bo'lganlini tekshirish uchun 1-list dan ( original, clone mas) elmentlarini o'zgartiriib tekshiring


namespace IClonableList_28_HT2
{
    internal class ClonableList<T> : List<T>, ICloneable where T : ICloneable
    {
        public object Clone()
        {
            ClonableList<T> clone = new ClonableList<T>();
            foreach (var item in this)
            {
                clone.Add((T)item.Clone());
            }

            return clone;
        }
    }
}



