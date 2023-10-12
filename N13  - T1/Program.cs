namespace N13____T1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Boshlang'ich herolar:");
        GameEngine gameEngine = new GameEngine();
        gameEngine.Display();

        Console.WriteLine("\nOptimallashtirilgan herolar:");
        OptimizedGameEngine optimizedGameEngine = new OptimizedGameEngine();
        optimizedGameEngine.Display();
    }
}
