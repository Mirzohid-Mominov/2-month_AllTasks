namespace CarRental_HT;

public abstract class CarRental
{
    public bool IsRented { get; set; }
    public DateTime RentStartTime { get; set; }

    public double Balance { get; set; }

    public string BrandName { get; set; }

    public int Id { get; set; }


    public CarRental(int id, string brandName) 
    {
        Id = id;
        BrandName = brandName;
        IsRented = false;
        Balance = 0;
        RentStartTime = DateTime.MinValue;
    }

    public abstract string ModelName { get; }
    public abstract double RentPricePerHour { get; }

    public override string ToString()
    {
        return $"{BrandName} {ModelName} (ID: {Id})";
    }






}


