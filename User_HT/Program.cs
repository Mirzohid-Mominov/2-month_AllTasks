﻿//#N24 #W3D2

//using static System.Net.WebRequestMethods;
//using System.Net;

//N24 - HT1

//User modelidan foydalaning ( id, firstname, lastname, emailAddress, isDeleted )
//UserCredentials modelidan foydalaning ( id, password, userId )
//FilterModel abstrakt modeldan foydalaning ( pageSize, pageToken )
//UserFilterModel dan foydalaning ( firstname?, lastname? ) u FilterModel dan inheritance olgan bo'lsin

//IUserService dan foydalaning
//unda quyidagi methodlar bo'lsin

//- Get ( pageSize, pageToken ) -userlarni pagination bian qaytarsin
//- Search ( searchKeyword, pageSize, pageToken ) -userlar ni kalit so'z bo'yicha qidirib pagination bilan qaytarsin
//- Filter ( userFilterModel ) -userlarni filter qilib pagination bilan qaytarsin
//- Add ( firstname, lastname, emailAddress ) -email address unique bo'lsa user ni qo'shsin va qaytarsin, bo'lmasa exception
//- Update ( user ) -userlar ichidan berilgan user borligini topib, update qilsin va qaytarsin, bo'lmasa exception
//- Delete ( id ) -userlar ichidan berilgan id bo'yicha user borligini topib IsDeleted true qilsin, bo'lmasa exception

//UserService da IUserService ni implement qiling

//IUserCredentialsService dan foydalaning
//unda quyidagi methodlar bo'lsin 

//- Add ( userId, password ) -password ni strong ekanligini regex bilan tekshirsin ( 8 <= simvol, 1 <= katta harf, 1 <= son ), valid bo'lsa qo'shsin va credential ni qaytarsin bo'lmasa exception
//- GetByUserId ( userId ) -user Id bo'yicha credential ni topib qaytarsin, bo'lmasa null

//UserCredentialsService da IUserCredentialsService ni implement qiling

//RegistrationService dan foydalaning
//unda quyidagi methodlar bo'lsin 

//- Register ( firstName, lastName, emailAddress, password ) -UserService orqali userni UserCredentialsService orqali credentialni qo'shsin, hammasi muvaffaqqiyatli bo'lsa true, bo'lmasa false qaytarsin

//PS : UserCredentialsService da parameterized konstruktor bo'lsin, u orqali IUserService va IUserCredentialsService implementatsiya qilgan tipdan object berib, fieldga saqlanadigan bo'lsin ( biz buni AccountService misolida ko'rganmiz )

//- dasturda UserCredentialsService dan object yarating
//- bir nechta userlar qo'shing va natijasini ekranga chiqaring
//- konsoldan keyword kiritib, userlar ni search qilib ekranga chiqaring

//class

// (https://t.me/c/1713738079/665)14.08.2023 #hometask


using User_HT;

var userService = new UserService();
var userCredentials = new UserCredentialsService();

// register obyektini yaratish
var register = new RegistrationService(userService, userCredentials);

// register
register.Register("Azizbek", "Abdurahmonov", "abdura52.uz@gmail.com", "qwery1234");
register.Register("Virginia", "Cox", "virginia@gmail.com", "password123456");
register.Register("Carolyn", "Ward", "carolyn@gmail.com", "qwerty123456");
register.Register("Catherine", "Hayes", "catherine@gmail.com", "securepass123456");
register.Register("Shirley", "Hamilton", "shirley@gmail.com", "testpass123456");
register.Register("Gloria", "Sanders", "gloria@gmail.com", "ilovecoding123456");
register.Register("Danielle", "Gonzalez", "danielle@gmail.com", "changeme123456");
register.Register("Christina", "Reyes", "christina@gmail.com", "mypassword123456");
register.Register("Debra", "Foster", "debra@gmail.com", "welcome123456");
register.Register("Janice", "Brooks", "janice@gmail.com", "randompass123456");
register.Register("Kelly", "Jenkins", "kelly@gmail.com", "secure123456");
register.Register("Martha", "Ward", "martha@gmail.com", "123456pass");
register.Register("Andrea", "Bryant", "andrea@gmail.com", "pass123456");
register.Register("Frances", "Perez", "frances@gmail.com", "123456test");
register.Register("Joyce", "Coleman", "joyce@gmail.com", "123456secure");
register.Register("Mary", "Nichols", "mary@gmail.com", "123456password");
register.Register("Theresa", "Johnson", "theresa@gmail.com", "123456random");
register.Register("Rita", "Patterson", "rita@gmail.com", "123456welcome");
register.Register("Rose", "Hernandez", "rose@gmail.com", "123456ilovecoding");
register.Register("Emma", "Ramirez", "emma@gmail.com", "123456changeme");
register.Register("Alice", "Butler", "alice@gmail.com", "123456mypassword");
register.Register("Julie", "Simmons", "julie@gmail.com", "12345678pass");
register.Register("Evelyn", "Barnes", "evelyn@gmail.com", "12345678test");
register.Register("Kim", "Fisher", "kim@gmail.com", "12345678secure");
register.Register("Maria", "Cole", "maria@gmail.com", "12345678password");
register.Register("Heather", "Mitchell", "heather@gmail.com", "12345678random");
register.Register("Diane", "Ortiz", "diane@gmail.com", "12345678welcome");
register.Register("Alice", "Gomez", "alice2@gmail.com", "12345678ilovecoding");
register.Register("Julia", "Murray", "julia@gmail.com", "12345678changeme");
register.Register("Grace", "Ford", "grace@gmail.com", "12345678mypassword");
register.Register("Victoria", "Patterson", "victoria@gmail.com", "12345678qwerty");
register.Register("Christine", "Howell", "christine2@gmail.com", "12345678abc123");
register.Register("Deborah", "Gonzalez", "deborah2@gmail.com", "12345678xyz987");
register.Register("Teresa", "White", "teresa2@gmail.com", "12345678letmein");
register.Register("Janet", "Hughes", "janet2@gmail.com", "12345678pass123");
register.Register("Denise", "King", "denise2@gmail.com", "12345678test123");
register.Register("Rebecca", "Brooks", "rebecca2@gmail.com", "12345678secure123");
register.Register("Catherine", "Baker", "catherine2@gmail.com", "12345678password123");
register.Register("Stephanie", "Hall", "stephanie2@gmail.com", "12345678random123");
register.Register("Kelly", "Adams", "kelly2@gmail.com", "12345678welcome123");
register.Register("Megan", "Russell", "megan2@gmail.com", "12345678ilovecoding123");
register.Register("Lisa", "Harris", "lisa@gmail.com", "securepassword");
register.Register("Betty", "Young", "betty@gmail.com", "pass1234");
register.Register("Dorothy", "Allen", "dorothy@gmail.com", "userpass");
register.Register("Sandra", "King", "sandra@gmail.com", "randompass123");
register.Register("Ashley", "Wright", "ashley@gmail.com", "welcome1234");
register.Register("Kimberly", "Lopez", "kimberly@gmail.com", "testpass");
register.Register("Donna", "Scott", "donna@gmail.com", "newpass");
register.Register("Emily", "Green", "emily@gmail.com", "password1234");
register.Register("Michelle", "Adams", "michelle@gmail.com", "securepass123");
register.Register("Carol", "Baker", "carol@gmail.com", "passw0rd123");
register.Register("Amanda", "Gonzalez", "amanda@gmail.com", "mypassword");
register.Register("Melissa", "Nelson", "melissa@gmail.com", "abc123");
register.Register("Deborah", "Carter", "deborah@gmail.com", "testpass1234");
register.Register("Stephanie", "Hill", "stephanie@gmail.com", "letmein1234");
register.Register("Rebecca", "Perez", "rebecca@gmail.com", "changeme123");
register.Register("Laura", "Roberts", "laura@gmail.com", "ilovecoding123");
register.Register("Sharon", "Turner", "sharon@gmail.com", "password12");
register.Register("Cynthia", "Phillips", "cynthia@gmail.com", "welcome12345");
register.Register("Kathleen", "Campbell", "kathleen@gmail.com", "pass12345");
register.Register("Amy", "Parker", "amy@gmail.com", "qwerty12345");


Console.WriteLine("Page size : 5, Page token : 2");
userService.Get(10, 3).ForEach(Console.WriteLine);

string keyword;
Console.Write("Enter keyword for search: ");
keyword = Console.ReadLine();
userService.Search(keyword, 8, 4).ForEach(Console.WriteLine);