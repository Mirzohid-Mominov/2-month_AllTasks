
//28 HT1
//IEvent interfeysidan foydalaning ( id, name, date ) 
//Event modelidan foydalaning - IEvent interfeysini implement qilgan bo'lsin

//Generic EventStack<T> kolleksidan foydalaning, bunda T ga IEvent constraint qo'llanilsin

//unda quyidagi methodlar bo'lsin 
//- Push(event) -agar push qilinayotgan event stack da bor eventlardan keyin bo'ladigan bo'lsa ( vaqti bo'yicha ), push bo'lsin, bo'lmasa esception
//- Peek - eventlar ichidan oxirgisini kolleksiyadan o'chirmasdan olib bersin
//- Pop  - eventlar ichidan oxirgisini kolleksiyadan o'chirib olib bersin

//- dasturdan EventStack dan object oling, bir nechta eventlar qo'shing va ekranga chiqaring


using Event_HT1;
using System.Diagnostics.Tracing;

var eventSack = new EventStack<Event>();

eventSack.Push(new Event("meeting with your job partner", new DateTime(2021, 03, 23)));
eventSack.Push(new Event("meeting teacher", new DateTime(2018, 08, 29)));

Console.WriteLine(eventSack.Pop());
Console.WriteLine(eventSack.Peek());




