namespace N13____T1;

class GameEngine
{
    protected List<Hero> heroes;

    public GameEngine()
    {
        heroes = new List<Hero>
        {
            new Hero { Id = 1, Name = "Yurnero" },
            new Hero { Id = 2, Name = "Sven" },
            new Hero { Id = 3, Name = "Tiny" }
        };
    }

    public virtual void Display()
    {
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero);
        }
    }
}

class OptimizedGameEngine : GameEngine
{
    public OptimizedGameEngine() : base()
    {
        // 3 ta hero qo'shamiz
        heroes.Add(new Hero { Id = 4, Name = "Invoker" });
        heroes.Add(new Hero { Id = 5, Name = "Lina" });
        heroes.Add(new Hero { Id = 6, Name = "Medusa" });
    }
}
