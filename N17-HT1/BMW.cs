namespace CarRental_HT;

public sealed class BMW : CarRental
{
    public BMW(int id) 
        : base(id, "BMW")
    {
    }

    public override string ModelName => "BMW";
    public override double RentPricePerHour => 30;
}

