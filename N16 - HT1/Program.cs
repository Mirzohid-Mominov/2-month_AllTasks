namespace N16___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        Spaceship spaceship = new Spaceship("Mercedes-Benz", 180, 150);
        spaceship.Display();
        Console.WriteLine();

        spaceship.Speed = 220;
        spaceship.Display();
        Console.WriteLine();

        spaceship.ExchangeTraectory("Namangan to Tashkent!");
        spaceship.Display();
        Console.WriteLine();

        spaceship.NewFuel(50);
        spaceship.Display();

    }
}