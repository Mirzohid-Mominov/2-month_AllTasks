using System.Net.Mail;
using User_LessonTask;

//N23 - T1

//- User modelidan foydalaning(emailAddress, password )

//-RegistrationServicedan foydalaning
//unda Users kolleksiyasi bo'lsin

//unda quyidagi methodlar bo'lsin
//- Register( emailAddress, password ) -agar email address mavjud bo'lsa ekranga "Bu email address allaqachon bor" degan message chiqsin bo'lmasa collection ga qo'shsin

//- dasturda RegistrationService dan object yarating
//- unga 3 unique user qo'shing
//- foydalanuvchidan email address va passwordni so'rab Register methodi orqali qo'shing




var register = new RegistrationService();
register.Register("com", "muhiddinov94");
register.Register("Salimov@gmail.com", "helloNamangan");
register.Register("Hoshimov@gmail.com", "helloNavoiy");
register.Register("Bahriddinov@gmail.com", "Tashkenthello");

Console.WriteLine("enter email");
var num = Console.ReadLine();

register.Register(num, "1232");