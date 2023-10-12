using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//bunda 
//- List<T> dan inheritance oling
//- ICloneable interfeysini implement qiling
//- T ga ICloneable constraint qo'llang

//StorageFile modelidan foydalaning ( id, name, description, size ), unda ICloneable ni implement qiling

//- dasturda ClonableList dan bitta object oling, ichiga bir nechta StorageFile objectlar qo'shing
//- list dan clone oling va deep copy bo'lganlini tekshirish uchun 1-list dan ( original, clone mas) elmentlarini o'zgartiriib tekshiring


namespace IClonableList_28_HT2
{
    public class StorageFile : ICloneable
    {
        public StorageFile( string name, string description, int size)
        {
            Id = new Guid();
            Name = name;
            Description = description;
            Size = size;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

        public object Clone()
        {
            return new StorageFile(this.Name, this.Description, this.Size);
        }

        public override string ToString()
        {
            return ($"Name : {Name}\tDescription : {Description}\tSize : {Size}");
        }

    }
}
