using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IEvent interfeysidan foydalaning ( id, name, date ) 
//Event modelidan foydalaning - IEvent interfeysini implement qilgan bo'lsin

//Generic EventStack<T> kolleksidan foydalaning, bunda T ga IEvent constraint qo'llanilsin

//unda quyidagi methodlar bo'lsin 
//- Push(event) -agar push qilinayotgan event stack da bor eventlardan keyin bo'ladigan bo'lsa ( vaqti bo'yicha ), push bo'lsin, bo'lmasa esception
//- Peek - eventlar ichidan oxirgisini kolleksiyadan o'chirmasdan olib bersin
//- Pop  - eventlar ichidan oxirgisini kolleksiyadan o'chirib olib bersin

//- dasturdan EventStack dan object oling, bir nechta eventlar qo'shing va ekranga chiqaring


namespace Event_HT1
{
    internal class EventStack<T> where T : IEvent
    {
        private List<T> _events;
        
        public EventStack()
        {
            _events = new List<T>();
        }

        public void Push(T item)
        {
            if(_events.All(t => t.Date <  item.Date))
            {
                _events.Add(item);
                return;
            }
            throw new Exception("There isn't your argument!!!");
        }

        public T Peek()
        {
            if (_events.Count() == 0)
                throw new Exception("There is free!!!");

            var lastEvents = _events.Last();
            return lastEvents;
        }

        public T Pop()
        {
            if (_events.Count() == 0)
                throw new Exception("There is free!!!");

            var lastEvent = _events.Last();
            _events.Remove(lastEvent);
            return lastEvent;
        }
    }
}
