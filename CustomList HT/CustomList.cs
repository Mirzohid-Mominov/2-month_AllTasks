using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CustomList - list kolleksiyasnini implementatsiyasini yarating, bunda generics dan foydalaning

//unda konstruktorlar
//- default
//- parameterli ( int capacity ) -list hajmini oldindan belgilash uchun

//unda methodlar 
//- Add ( item ) -bitta element qo'shadi - item 
//- AddRange ( items ) -bir nechta element qo'shadi
//- Contains ( item ) -bitta element bor/yo'qligini tekshiradi
//- CopyTo ( array ) -list elementlarini berilgan arrayga copy qiladi
//- IndexOf ( item ) -berilgan element listda uchrassa index qaytaradi, bo'lmasa -1
//- Insert ( index, item ) -berilgan index mavjud bo'lsa element qo'shadi, bo'lmasa exception
//- InsertRange ( index, items ) -berilgan index mavjud bo'lsa elementlarni qo'shadi bo'lmasa exception
//- Remove ( item ) -berilgan element listda uchrasa o'chiradi va true qaytaradi, bo'lmasa false
//- RemoveAt ( index ) -berilgan indexdagi elementni o'chiradi va true qaytaradi, bo'lmasa false
//- ToArray - list elementlarini array ko'rinishida qaytaradi 

namespace CustomList_HT
{
    internal class CustomList<T>
    {   
        private readonly int _capacity = 0;
        private T[] _items;

        public CustomList()
        {
            _items = new T[_capacity];
        }

        public CustomList(int _size)
        {
            if (_size < 0)
                throw new Exception("Array length cannot be less than 0");
            else
                _items = new T[_capacity];
        }

        public void Add(T item)
        {
            CheckSize();
            _items[_items.Length - 1] = item;
        }

        public void AddRange(params T[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Contains(T item)
        {
            foreach (var itemA in _items)
                if (itemA.Equals(item)) return true;

            return false;
        }
        public void CopyTo(T[] array)
        {
            if (array.Length < _items.Length)
                throw new Exception("length of array is less than length of list");
                
            for (var i = 0; i < _items.Length; i++)
                array[i] = _items[i];
        }
        //- IndexOf ( item ) -berilgan element listda uchrassa index qaytaradi, bo'lmasa -1
        public int IndexOf(T item)
        {
            for (var i = 0; i < _items.Length; ++i)
            {
                if (_items[i].Equals(item))
                    return i;
            }
            return -1;

        }
        //- Insert ( index, item ) -berilgan index mavjud bo'lsa element qo'shadi, bo'lmasa exception

        public void Insert(int index, T item)
        {
            var newArray = new T[_items.Length + 1];

            for (var i = 0; i < index; ++i)
                newArray[i] = _items[i];

            newArray[index] = item;

            for (var indexB = index + 1; indexB < newArray.Length; indexB++)
            {
                newArray[indexB] = _items[indexB - 1];
            }


            _items = newArray;
        }
        //- InsertRange ( index, items ) -berilgan index mavjud bo'lsa elementlarni qo'shadi bo'lmasa exception

        public void InsertRange(int index, params T[] items)
        {
            foreach (var item in items)
            {
                Insert(index, item);
                index++;
            }
        }
        //- Remove ( item ) -berilgan element listda uchrasa o'chiradi va true qaytaradi, bo'lmasa false

        public bool Remove(T item)
        {
            try
            {

                var newArray = new T[_items.Length - 1];

                bool isNotFound = true;
                var index = 0;
                for (var idx = 0; idx < _items.Length; idx++)
                {
                    if (_items[idx].Equals(item) && isNotFound)
                    {
                        isNotFound = false;
                    }
                    else
                    {
                        newArray[index] = _items[idx];
                        index++;
                    }
                }

                if (isNotFound)
                    return false;
                else
                {
                    _items = newArray;
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }
        //- RemoveAt ( index ) -berilgan indexdagi elementni o'chiradi va true qaytaradi, bo'lmasa false

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _items.Length)
                return false;

            var newArray = new T[_items.Length - 1];

            bool isNotFound = true;
            var indexB = 0;
            for (var idx = 0; idx < _items.Length; idx++)
            {
                if (idx == index && isNotFound)
                {
                    isNotFound = false;
                }
                else
                {
                    newArray[indexB] = _items[idx];
                    indexB++;
                }
            }

            if (isNotFound)
                return false;
            else
            {
                _items = newArray;
                return true;
            }

        }


        public T[] ToArray()
        {
            return _items;
        }

        public void CheckSize()
        {
            Array.Resize(ref _items, _items.Length + 1);

        }
        public override string ToString()
        {
            var Items = string.Empty;
            foreach (var item in _items)
                Items += item + " ";
            return Items;
        }
    }
}
