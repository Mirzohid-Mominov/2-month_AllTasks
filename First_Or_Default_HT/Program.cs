

//N22-HT2 - first or default, all, any

//review - biror service / narsa uchun berilgan fikr
//star - review dagi yulduzlar bilan baholash usuli ( 1 dan 5 gacha ) 
//message - review ga yozilgan xabar, tushuntirish

//- IReview interfeysdan foydalaning ( id, star, message )
//-Review modelidan foydalaning(id, star, message ) -IReview ni implement qilsin
//- CrashReport modelidan foydalaning ( id, star, message, screenshot ) -IReview ni implement qilsin

//IReviewList<TReview> interfeysidan foydalaning, TReview ga IReview bilan constraint qo'ying

//unda quyidagi methodlar bo'lsin

//- Add ( review ) -reviewni reviewlar kolleksiyasiga qo'shsin
//- Update ( id, star, message ) -review ni update qilsin
//- Remove ( id ) -review ni kolleksiyadan o'chirsin
//- Remove ( review ) -kolleksiyadan berilgan review ni id bo'yicha qidirib, topilsa o'chirsin
//- GetReview ( id ) -reviewni id bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
//- GetReview ( message ) -review ni message bo'yicha topib qaytarsin, bo'lmasa null qaytarsin  
//- GetOverallReview - review lar bo'yicha umumiy xulosa ni string da chiqarsin

//ReviewList<TReview> modelidan foydalaning, unda IReviewList<TReview> ni impleemnt qiling
//bunda GetOverallReview bunday ishlashi kerak : 

//agar
//- reviewlar soni 0 bo'lsa - "Be the first to leave a review for this product"
//- reviewlar barchasi 5 star bo'lsa - "Great news! All reviews for this product are 5-star ratings."
//- agar reviewlar orasida 1 star bo'lsa - o'sha reviewdagi message chiqsin

//- dasturda ReviewList<TReview> dan object yarating
//- GetOverallReview dan foydalanib ko'ring
//- bir nechta Review va CrashReport dan object yaratib qo'shing
//- ekranga id bo'yicha va message bo'yicha qidiirib ko'rib chiqaring
//- bitta review ni update qiling
//- yana GetOverallReview dan foydalanib ko'ring

//PS : CrashReport da screenshot image fayl ga bo'lgan yo'l ( path ) ni saqlashligi kerak, bo'sh string qilib ketilsa ham bo'ladi

using First_Or_Default_HT;

var reviewList = new ReviewList<IReview>();
reviewList.GetOverallReview();


var review1 = new Review("1-revew message", 3);
var review2 = new Review( "2-review message", 2);
var crash1 = new CrashReport(3, "1-crash report message", "screenshot/path.png");
var crash2 = new CrashReport(5, "2-crash report message", "screenshot/path2.png");

reviewList.Add(review1);
reviewList.Add(review2);
reviewList.Add(crash1);
reviewList.Add(crash2);

Console.WriteLine("OverallReview: ");
reviewList.GetOverallReview();
Console.WriteLine(review1);


reviewList.Update(crash1.Id, 1, "O'zgartirilgan message");
Console.WriteLine(crash1);