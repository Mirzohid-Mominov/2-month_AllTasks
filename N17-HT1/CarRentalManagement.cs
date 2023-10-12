using CarRental_HT;
//using System.Reflection.Metadata;
//using System.Reflection;

//N17 - HT1 - abstract, selaed, parameterized, default

//rent - ijaraga olish
//return - qaytarish

//- CarRental abstract modelidan foydalaning

//  unda quyidagi propertylar bo'lsin
//- IsRented - hozirda ijarada / ijarada mas
//- RentStartTime - ijaraga oligan vaqt
//- Balance - ijaradan shu moshina uchun tushgan pullar
//- BrandName - moshina brandi
//- Id - moshina unique Id si

//Bmw - CarRental dan inheritance olgan sealed model bo'lsin
//Audi - CarRental dan inheritance olgan selaed model bo'lsin

//ularda BrandName ga model nomi qiymati berilgan bo'lsin

//ularda quyidagi propertylar bo'lsin
//  - ModelName
//  - RentPricePerHour - soatiga ijara puli ( BMW - 30, Audi - 20 $ bo'lsin )

//ularda quyidagi konstruktorlar bo'lsin
//  - parameterli ( model name ) 

//CarRentalManagement service dan foydalaning

//unda quyidagi propertylar bo'lsin 
//- Cars - hozirda ijara kompaniyasidagi moshinalar kolleksiyasi ( CarRental tipidagi kolleksiya )

//unda quyidagi methodlar bo'lsin 
//- Add ( Car ) -moshinalar kolleksiyasiga bitta moshina qo'shsin
//- Rent ( brandName ) -agar o'sha brand bo'yicha moshina topilsa - RentStartTime ga hozirgi vaqt qiymati qo'yilsin, IsRented ga true, qiymati qo'yilsin va moshina objectini qaytarsin, bo'lmasa "Uzr, hozirda ijaraga moshina yo'q" yozuvchi chiqsin
//- Return ( car ) -parameterda berilgan car objectini Id si bo'yicha kolleksiyadan topilsin, IsRented ga false qiymat berilib, ijaraga berilgan vaqt ( RentStartTime ) dan o'tgan vaqt hisoblanib, sekundiga ( real hayotda soatiga ) RentPriceNumber bo'yicha hisoblansin  balance ga qo'shilsin
//- CalculateBalance - barcha moshinalardagi balancelarni qo'shib ekranga chiqarsin

//unda quyidagi konstruktorlar bo'lsin
//- default konstruktor - unda Cars kolleksiyasiga bo'sh kolleksiya qiymatini yozing

//- dasturda CarRentalManagement dan object yarating
//- BMW va Audi dan uchtadan object yarating va CarRentalManagement service ga qo'shing
//- 4 ta ixiyoriy moshinadan ijara olib, return qiling, umumiy balanceni hisoblab ekranga chiqaring

//Izoh : dastur sekundlardan tez ishlagani uchun ijara olganda bir necha sekundlar o'tishligi uchun await Task.Delay(1000 * sekund) dan foyalanilsin

//Example 

//Bu ishlash jarayoni, konsolga shunday chiqishi shartmas

//rent BMW - 5 sekund - return    - 5 * 30 = 150
//rent BMW - 6 sekund - return    - 6 * 30 = 180
//rent Audi - 4 sekund - return   - 4 * 20 = 80
//rent BMW - 3 sekund - return    - 3 * 20 = 60

//Umumiy balance - $470

internal class CarRentalManagement
{
    public List<CarRental> Cars { get; }

    public CarRentalManagement()
    {
        Cars = new List<CarRental>();
    }

    public void Add(CarRental car)
    {
        Cars.Add(car);
    }

    public  CarRental Rent(string brandName)
    {
        CarRental car = Cars.Find(c => c.BrandName == brandName && !c.IsRented);

        if (car != null)
        {
            car.IsRented = true;
            car.RentStartTime = DateTime.Now;
            Console.WriteLine($"Rented: {car}");
            return car;
        }

        Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q");
        return null;

    }

    public void Return(CarRental car)
    {
        if (car.IsRented)
        {
            TimeSpan rentDuration = DateTime.Now - car.RentStartTime;
            int rentDurationInSeconds = (int)rentDuration.TotalSeconds;
            double rentPrice = rentDurationInSeconds * car.RentPricePerHour;

            car.Balance += rentPrice;
            car.IsRented = false;
            car.RentStartTime = DateTime.MinValue;
            Console.WriteLine($"Returned: {car}\nRent Duration: {rentDurationInSeconds}\nBalance: {car.Balance}");
        }
        else
        {
            Console.WriteLine($"{car} is not rented and cannot be returned.");
        }

    }

    public void CalculateBalance()
    {
        double totalBalance = 0;
        foreach (var car in Cars)
        {
            totalBalance += car.Balance;
        }
        Console.WriteLine($"Total Balance: {totalBalance}");
    }

}
