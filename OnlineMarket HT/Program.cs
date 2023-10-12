//N20-HT1 - online market

//IDebitCard interfeysidan foydalaning

//unda quyidagi propertylar bo'lsin
//- CardNumber - karta raqami
//- BankName - bank nomi ( init only )
//-Balance - hozirgi kartadagi balans

//quyidagi modellar IDebitCard ni implement qilgan bo'lsin

//- KapitalUzcard
//- MillyHumo

//IPaymentProvider interfeysidan foydalaning

//unda quyidagi methodlar bo'lsin
//- Transfer ( sourceCard, destinationCard, amount ) -pulni bir kartadan ikkinchi kartaga o'tkazsin

//unda quyidagi propertylar bo'lsin
//- TransferInterest ( init-only ) -har bitta trazaksiya uchun yechib olinadigan foiz 

//PaymePaymentProvider tipini yarating, unda IPaymentProvider interfeysini implement qiling
//UzumPaymentProvider tipini yarating, unda IPaymentProvider interfeysini implement qiling

//Product modelidan foydalaning 
//unda quyidagi propertylar bo'lsin 
//- Name
//- Price

//OnlineMarket servisidan foydalaning
//unda quyidagi konstruktor bo'lsin
//- OnlineMarket ( IPaymentProvider provider ) -bunda provider private readonly fieldga saqlansin

//unda quyidagi methodlar bo'lsin
//- Add ( product ) -productlar qatoriga berilgan productni qo'shsin ) 
//- Buy ( name, number, card ) -product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab, kartadan pul yechishni payment provider orqali amalga oshirsin

//- dasturda o'zingiz xohlagan payment provider ( KapitalUzcard, MillyHumo ) dan instance ( object ) yarating
//- OnlineMarket dan o'sha provider bilan instance yarating
//- Product dan bir nechta instance yarating va OnlineMarket ga qo'shing
//- o'zingiz xohlagan kartadan ( KapitalUzcard yoki MillyHumo ) instance yarating 
//- bir nechta produktlarni sotib olish operatsiyasini OnlineMarket orqali bajaring
//- kartada qolgan summani ekranga chiqaring



//Online market kartasi va provideri
using OnlineMarket_HT;

var MarketCard = new KapitalUzcard("8600010107717125", "AloqaBank", 0);
var provider = new UzumPaymentProvider();

var OnlineMarket = new OnlineMarket(provider, MarketCard);

//Marketga productlar qo'shish
OnlineMarket.AddProduct(new Product("Shaptoli", 20_000));
OnlineMarket.AddProduct(new Product("Tarvuz", 3_000));
OnlineMarket.AddProduct(new Product("Katoshka", 8_000));
OnlineMarket.AddProduct(new Product("Piyoz", 10_000));
OnlineMarket.AddProduct(new Product("Qovun", 10_000));

//foydalanuvchining shaxsiy kartasi
var MyPersonalCard = new KapitalUzcard("86008384951739427", "UzBankN1", 700_000_000);


//Productlar sotib olish
Console.WriteLine(
    OnlineMarket.BuyProduct("Qovun", 3, MyPersonalCard)
    ? "Qovun - muvaffaqiyatli sotib olindi"
    : "Mahsulot topilmadi yoki Balansingizda yetarli mablag' mavjud emas");

Console.WriteLine(
    OnlineMarket.BuyProduct("Shaptoli", 10, MyPersonalCard)
    ? "Shaptoli - muvaffaqiyatli sotib olindi"
    : "Mahsulot topilmadi yoki Balansingizda yetarli mablag' mavjud emas");

Console.WriteLine($"Kartangizdagi qoldiq: {MyPersonalCard.Balance}");















