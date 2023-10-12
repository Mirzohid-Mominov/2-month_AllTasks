//N29 - HT2

//Employee - xodim
//Hire - ishga oilsh, xodim sifatida ro'yxatdan o'tkazish

//Employee modeldan foydalaning ( id, firstname, lastname )

//EmployeeService servicedan foydalaning

//unda HireAsync(firstname, lastname, emailAddress) methodi bo'lsin

//bunda 
//- xodimga confirmation email jo'nating 
//- email jo'natilgungacha $"{firstname} {lastname}`s employment contract.docs" faylini yarating
//- confirmation email jo'natib bo'lingach, welcome on board email ni jo'nating
//- fayl yaratib bo'lingach ichiga employment contract textini yozib qo'ying
//- welcome on board email jo'natib bo'lingach, office policies emailini jo'nating




using Emplee_29_HT2;

var employee= new Employee("Mirzohid", "Mo'minov", "momirzohid4@gmail.com");
var service = new EmployeeService();
await service.HireAsync(employee);
