namespace N13___HT3;

public class BankAccount
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Deposit { get; set; }


    public BankAccount(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Deposit = -20;
    }

    public BankAccount(string firstName, string lastName, decimal deposit)
    {
        FirstName = firstName;
        LastName = lastName;
        Deposit = deposit >=0 ? deposit : 0;
    }

    public void DisplayBankAccount()
    {
        Console.WriteLine("Account Holder: " +FirstName+" "+ LastName);
        Console.WriteLine("Deposit: $"+Deposit);
        Console.WriteLine();
    }


}
