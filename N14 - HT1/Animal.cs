namespace N14___HT1;

public class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("Interesting fact");
    }


}

public class Quyon:Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Interesting fact with: Quyon");
    }
}

public class Kaptar : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Interesting fact with: Kaptar");
    }
}

public class Baliq : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Interesting fact with: Baliq");
    }
}
