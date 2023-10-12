namespace N18___T1;

public abstract class Car
{
    public string Brand { get; init; }
    public int Year { get; init; }
    public string Color { get; set; }

    public Car(string brand, int year, string color)
    {
        Brand = brand;
        Year = year;
        Color = color;
    }

    public virtual void Show()
    {

    }

    public abstract void Drive();
}


public class Malibu : Car
{
    static int Passangers { get; set; }
    private readonly int _maxSpeed;

    public int MaxSpeed { get; }

    public Malibu(string brand, int year, string color, int maxSpeed, int passengers)
        : base(brand, year, color)
    {
        MaxSpeed = maxSpeed;
        Passangers = passengers;
    }

    public override void Show()
    {
        Console.WriteLine($"Brand: {Brand}\nYear: {Year}\nColor: {Color}\nMaxSpeed: {MaxSpeed}\nPassenger: {Passangers}\n");

    }

    public override void Drive()
    {
        Show();
        int speed = 0;
        var random = new Random();
        while (true)
        {
            if (speed >= 100)
            {
                Console.WriteLine($"Speed Malibu: {speed}");
                break;
            }

            speed = random.Next(speed, speed + 11);
            Console.WriteLine($"Speed Malibu: {speed}");
            Thread.Sleep(800);



        }

    }

}

public class Captiva : Car
{
    static int Passangers { get; set; }
    private readonly int _maxSpeed;

    public int MaxSpeed { get; }

    public Captiva(string brand, int year, string color, int maxSpeed, int passengers)
       : base(brand, year, color)
    {
        MaxSpeed = maxSpeed;
        Passangers = passengers;
    }

    public override void Show()
    {
        Console.WriteLine($"Brand: {Brand}\nYear: {Year}\nColor: {Color}\nMaxSpeed: {MaxSpeed}\nPassenger: {Passangers}\n");

    }
    public override void Drive()
    {
        Show();
        int speed = 0;
        var random = new Random();
        while (true)
        {
            if (speed >= 100)
            {
                speed = 100;
                Console.WriteLine($"Speed Captiva: {speed}");
                break;
            }

            speed = random.Next(speed, speed + 11);
            Console.WriteLine($"Speed Captiva: {speed}");
            Thread.Sleep(800);



        }

    }

}


