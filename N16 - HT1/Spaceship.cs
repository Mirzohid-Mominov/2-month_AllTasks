namespace N16___HT1;

internal class Spaceship
{
    public string Name { get; init; }
    public int Fuel { get; private set; }
    public int Speed { get; set; }
    public string Trayectory { private get; set; }

    public Spaceship(string name, int fuel, int speed)
    {
        Name = name;
        Fuel = fuel;
        Speed = speed;
    }

    public void NewFuel (int fuel)
    {
        if (fuel < 0)
            Console.WriteLine("gaz quyilmadi!");
        else
            Fuel += fuel;
    }

    public void ExchangeTraectory(string newTrajectory)
    {
        Console.WriteLine($"Trayektoriya o'zgartirildi:{newTrajectory}");
        Trayectory = newTrajectory;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Fuel: {Fuel}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"Trajectory: {Trayectory}");
    }

}
