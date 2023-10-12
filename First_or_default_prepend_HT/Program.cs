//N27 - HT1 first or default, prepend

//User modelidan foydalaning ( id, emailAddress, password, isAdmin )

//UserService dan foydalaning
//unda quyidagi methodlar bo'lsin
//- Users collection
//- Add ( emailAddress, password ) -user ni validate qilib qo'shadi
//- GetUsers - userlar kolleksiyasini qaytaradi 

//foydalanuvchilar orasida asosan admin foydalanuvchi hamma foydalanuvchilardan oldin registratsiya bo'lgan bo'lishi kerak

//- UserService da Users collectionga initialize qilganda default qilib 3 ta user qo'shib qo'ying
//- Add methodi orqali 2 ta user qo'shing
//- GetUsers methodi orqali User larni olib, ekranga chiqaring

//PS : bunda EnsureAdminExists private methodi orqali admin borligini tekshirib userlar orasiga qo'shib qo'yish mumkin va bu methodni konstruktorda ishlatsa bo'ladi


using First_or_default_prepend_HT;



var service = new UserService();
service.Add("mominov04@gmail.com", "muhiddinov94");
service.Add("Asadov@gmail.com", "qwert12345");

service.GetUser().ForEach(Console.WriteLine);








