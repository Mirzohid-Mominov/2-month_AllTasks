using CarRental_HT;
        CarRentalManagement carRentalManagement = new CarRentalManagement();

        CarRental bmw1 = new BMW(1);
        CarRental bmw2 = new BMW(2);
        CarRental audi1 = new Audi(3);
        CarRental audi2 = new Audi(4);

        carRentalManagement.Add(bmw1);
        carRentalManagement.Add(bmw2);
        carRentalManagement.Add(audi1);
        carRentalManagement.Add(audi2);


        var rent1 =  carRentalManagement.Rent("BMW");
        await Task.Delay(5000);
        carRentalManagement.Return(rent1);

var rent2 = carRentalManagement.Rent("BMW");
await Task.Delay(6000);
carRentalManagement.Return(rent2);

var rent3 = carRentalManagement.Rent("Audi");
await Task.Delay(4000);
carRentalManagement.Return(rent3);

var rent4 = carRentalManagement.Rent("Audi");
await Task.Delay(3000);
carRentalManagement.Return(rent4);

carRentalManagement.CalculateBalance();