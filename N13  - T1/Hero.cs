namespace N13____T1;

class Hero
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Name}";
    }
}
