//N28 - HT2

//ClonableList<T> dan foydalaning 

//bunda 
//- List<T> dan inheritance oling
//- ICloneable interfeysini implement qiling
//- T ga ICloneable constraint qo'llang

//StorageFile modelidan foydalaning ( id, name, description, size ), unda ICloneable ni implement qiling

//- dasturda ClonableList dan bitta object oling, ichiga bir nechta StorageFile objectlar qo'shing
//- list dan clone oling va deep copy bo'lganlini tekshirish uchun 1-list dan ( original, clone mas) elmentlarini o'zgartiriib tekshiring


using IClonableList_28_HT2;

var clonableList = new ClonableList<StorageFile>
{
    new StorageFile("first File", "first desctop", 232),
    new StorageFile("second File", "second desctop", 2445),
    new StorageFile("third File", "thrist desctop", 4545),
 
};

var cloned = (ClonableList<StorageFile>)clonableList.Clone();

var firstItem = clonableList.First();
firstItem.Description = "Hello World !!!";
firstItem.Name = "Asadbeks'file";

var thirdItem = clonableList.Last();
thirdItem.Size = 323;


clonableList.ForEach(Console.WriteLine);



