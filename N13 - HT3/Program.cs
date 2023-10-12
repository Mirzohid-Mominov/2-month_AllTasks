namespace N13___HT3;

internal class Program
{
    static void Main(string[] args)
    {
        // 2 Xil bank account yaratamiz
        BankAccount account1 = new BankAccount("Ali", "Vali");
        BankAccount account2 = new BankAccount("John", "Doe", 875);

        // Accountlar datallarini ko'rish
        Console.WriteLine("Account1:");
        account1.DisplayBankAccount();

        Console.WriteLine("Account2: ");
        account2.DisplayBankAccount();


    }
}