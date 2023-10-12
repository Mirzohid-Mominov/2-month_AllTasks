namespace N16___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        SmartHomeService smartHome = new SmartHomeService("Avalon");

        smartHome.ExpectedTemperature = 12;
        smartHome.SetCurrentTemperature(20);
        smartHome.Activate();
        smartHome.Display();

        smartHome.SetCurrentTemperature(30);
        smartHome.Display();

        smartHome.SetCurrentTemperature(20);
        smartHome.Display();

        smartHome.ExpectedTemperature = 25;
        smartHome.SetCurrentTemperature(21);
        smartHome.Display();

    }
}