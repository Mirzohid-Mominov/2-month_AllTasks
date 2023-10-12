//Product - mahsulot

//IProduct interfeysdan foydalaning ( id, name, description, isOrdered, price )
//Laptop modelidan foydalaing - ( cpuBrand, cpuModel ) -IProduct implementatsiyasi
//Chair modelidan foydalaning - ( maxWeight, material ) -IProduct implementatsiyasi
//Monitor modelidan foydalaning - ( displaySize, refreshRate ) -IProduct implementatsiyasi
//DebitCard modelidan foydalanig - ( cardNumber, balance ) 

//ProductFilterDataModel modeldan foydalaning, unde quyidagi propertylar bo'lsin
//- ProductTypes - hozirda mavjud produkt tiplari unique qilib olingani ( IEnumerable<string>, bu collection.Select(item => item.GetType().FullName) qilib olinadi )

//ProductFilterModel modelidan foydalaning ( name, type )

//IProductService dan foydalaning 
//- Inventory - IProduct tipidagi kolleksiya
//- Add ( product ) -inventoryga product qo'shsin
//- GetFilterData - filter data model yasab qaytarsin, agar birorta produkt bo'lmasa filter model da empty value bo'lsin ( list uchun empty list )

//ProductService da IProductService ni imiplement qiling  

//- Get ( filterModel ) -filter bo'yicha topilgan produktlarni copy constructor orqali nusxasini qaytarsin 
//- Order ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = true qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception
//- Return ( product id ) -berilgan produktni topib, o'sha produktni isOrdered = false qilsin va copy konstruktor orqali nusxasini qaytarsin, topilmasa exception

//PaymentService dan foydalaning 
//- Checkout ( amount, debitCard ) -agar kartada yetarli miqdorda pul bo'lsa minus qilib, true qaytarsin, bo'lmasa false

//PaymentService da IPaymentService ni implement qiling

//IOrderService dan foydalaning - bunda ProductService va PaymentService composition qilib ishlatilsin
//- Order ( id, card ) -bitta mahsulot xarid qilish
//- Order ( filterModel, card ) -bir nechta mahsulot har qilish 

//OrderService da IOrderService ni implement qiling

//bu methodlar logikasi
//- ProductService dan foydalanib, mahsulotni Order qilganda Product qaytsa ( null emas ), Checkout methodini ishlatib kartadan pul yechib oling, agar pul yechish o'xshamasa Return bilan mahsulotlarni joyiga qaytaring, agar hammasi o'xshasa true, bo'lmasa false qaytsin

//- dasturda OrderService ni kerakli dependencylari bilan yarating ( demak oldin ProductService va PaymentService dan instance olish kerak )
//-ProductService orqali 10 ta mahsulot qo'shing
//- hozirda qaysi mahsulot turlari borligini ekranga chiqaring
//- bitta card yarating va xarid qilishni har xil holatlarda sinab ko'ring


using Product_HT;
using Product_HT.Services;
using Monitor = Product_HT.Monitor;

//var productService = new ProductService();
//var paymentService = new PaymentService();


//var orderService = new OrderService(productService, paymentService);

var productService = new ProductService();
var paymentService = new PaymentService();

var orderService = new OrderService(productService, paymentService);

//add monitors
var m1 = new Product_HT.Monitor("Monitor-1 pro", "ajoyib monitor", false, 3_848_383, 20, 144); ;
productService.Add(m1);

var m2 = new Monitor("Monitor-2 pro", "ajoyib monitor 2 ", false, 3_832_289, 13, 120); ;
productService.Add(m2);

var m3 = new Monitor("Monitor-3 pro", "ajoyib monitor - 3", false, 6_423_595, 10, 144); ;
productService.Add(m1);

var m4 = new Monitor("Monitor-4 pro", "ajoyib monitor - 4 ", false, 7_233_213, 18, 120); ;
productService.Add(m2);

// add laptops
var l1 = new Laptop("HP", "ajoyib", false, 5_000_000, "ryzen7", "amd");
productService.Add(l1);

var l2 = new Laptop("HP-2", "ajoyib2", false, 6_000_000, "intel", "core");
productService.Add(l2);

var l3 = new Laptop("Victus", "ajoyib3", false, 7_000_000, "ryzen5", "amd");
productService.Add(l3);

// add chairs
var ch1 = new Chair("chair1", "ajoyib-chair1", false, 200_000, 10, "nimadir");
productService.Add(ch1);

var ch2 = new Chair("chair2", "ajoyib-chair2", false, 200_000, 13, "nimadir");
productService.Add(ch2);
var ch3 = new Chair("chair3", "ajoyib-chair1", false, 400_000, 15, "nimadir");
productService.Add(ch3);

Console.Write("there are some types : ");
productService.GetFilterData().ProductTypes.ToList().ForEach(Console.Write);

var myCard = new DebitCard ( "9860_0140_4294_8493",  150_500_999 );

Console.WriteLine("balance: " + myCard.Balance);

if (orderService.Order(ch1.Id, myCard))
    Console.WriteLine("bought");
else
{
    Console.WriteLine("Error");
}

Console.WriteLine("Balance: " + myCard.Balance);
















