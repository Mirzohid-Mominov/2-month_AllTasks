public enum MoneyType
{

}

public class Money
{
    public Money(int amount, MoneyType type)
    {
        Amount = amount;
        Type = type;
    }

    public int Amount { get; set; }
    public MoneyType Type { get; set; }

    public Money() { }

    public static Money operator +(Money first, Money last)
    {
        // moneyA va moneyb bir xil tipda bolsa - qoshiladi
        // moneyA in balance va moneyB loan bolsa - moneyA dan moneyB ni ayriladi
        // moneyB loan va moneyB in balance bolsa - moneyB dan moneyA ni ayriladi

        if(first.Type == last.Type)
        {
            return new Money(first.Amount + last.Amount, first.Type);
        }
        else
        {
            
        }
        return new Money();
    }
}

public class Skill
{
    public Skill(string name, int level)
    {
        Id = new Guid();
        Name = name;
        Level = level;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
}

public static class CollectionExtensions
{
    public static ICollection<Skill>  Update(this ICollection<Skill> first, ICollection<Skill> second)
    {
        var list = first.ToList();
        var addedItems = second.ExceptBy(first.Select(firstItem => firstItem.Id), item => item.Id);
        var 
    }
}
