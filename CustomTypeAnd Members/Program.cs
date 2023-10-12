//Data Structure and OOP

//N32-T1 - custom type and members

//- ShortenedLink modelidan foydalaning ( id, originalUrl, shortenedUrl ) 
//-undan bir nechta object yarating, tengligini tekshiring

//N32-T2 - model, inheritance, polymorphism, class types, data members

//- AuditableEntity abstract modelidan foydalaning(createdDate, modifiedDate )
//-ChatMessage modelidan foydalaning(id, subject, message, chatId )

//unda
//- AuditableEntity dan inheritance oling
//- ToString, GetHashcode, Equals methodlarini override qiling
//- bir nechta object yarating va ekranga chiqaring
//- 2 ta propertylari bir xil bo'lgan message teng ekanligini ekranga chiqaring


using CustomTypeAnd_Members;

var urls1 = new ShortedLink("https://docs.dot-net.uz/c-.net/linq/select", "https://docs.dot-net.uz/c-.net/linq/select");
var urls2 = new ShortedLink("https://docs.dot-net.uz/c-.net/linq/select", "https://docs.dot-net.uz/c-.net/linq/select");




Console.WriteLine(urls1 != urls2);