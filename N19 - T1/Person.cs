namespace N19___T1;

internal class Person
{
    private string _name;
    private int _age;
    private string _city;
    private readonly string _nationally;

    public Person() { }

    public Person(string name, int age, string city, string nationally)
    {
        _name = name;
        _age = age;
        _city = city;
        _nationally = nationally;
    }

    static Person()
    {
        Console.WriteLine("Activated");
    }

    public Person(Person person)
    {
        _name = person._name; 
        _age = person._age;
        _city = person._city;
        _nationally = person._nationally;
    }




}
