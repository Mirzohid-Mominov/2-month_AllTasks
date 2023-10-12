//N32 - T3 - property types, constructor types

//Product modelidan foydalaning ( id, name, description )
//-bunda id init-only bo'lsin
//- name va description read-only bo'lsin ( private set )
//- name va descriptino getter methodi ichida name va description ni validate qiling ( regex dan foydalanish ixtiyoriy, is null or white space yetarli )
//-parameterized constructorda name va description bo'lsin
//- copy constructor orqali Product ni copy qiladigan qiling

//- Product modelidan bir nechta object yarating ( valid va invalid )
//-Singleton pattern ishlatilgan ProductService ni yarating
//- unda Add methodi bo'lsin ( name, description ), agar product yaratishda exception bo'lsa konsolga exception chiqsin
//- unda Clone methodi bo'lsin ( id ) - u product ni topib, copy qilinganini kolleksiyaga qo'shib qo'ysin
//- unda Display methodi hamma productlarni ekranga chiqarsin

//- ProductService dan instance oling, valid invalid modellar qo'shib, Clone methodi orqali clonelar qilib, ekranga chiqaring



using Property_constructor_Types;

var products1 = new Product("olma", "nordon");
var products2 = new Product("shaftoli", "tuksiz");
var products3 = new Product("qulupnay", "yaxshi pishgan");
var products4 = new Product("uzum", "qora uzum");
Console.WriteLine(products3);
var productService = new ProductService();
productService.Add("jdnsjd", "skdmnsmd");
productService.Display();








