
//N32-T2 - model, inheritance, polymorphism, class types, data members

//- AuditableEntity abstract modelidan foydalaning(createdDate, modifiedDate )
//-ChatMessage modelidan foydalaning(id, subject, message, chatId )

//unda
//- AuditableEntity dan inheritance oling
//- ToString, GetHashcode, Equals methodlarini override qiling
//- bir nechta object yarating va ekranga chiqaring
//- 2 ta propertylari bir xil bo'lgan message teng ekanligini ekranga chiqaring



using ModelInheritanceInterface_lessontask2;

Console.WriteLine(new ChatMessage("Mirzohid", "What's up", 1));
Console.WriteLine(new ChatMessage("Asilbek", "What's up", 1));
Console.WriteLine(new ChatMessage("Xurshid", "What's up", 1));
Console.WriteLine(new ChatMessage("Jamshid", "What's up", 1));































