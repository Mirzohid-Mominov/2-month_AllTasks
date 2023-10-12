namespace N19___T2;

abstract class BankAccount
{
    protected string AccountHolderName;
    protected int AccountNumber;
    protected decimal Balance;

    public BankAccount(decimal balance)
    {
        Balance = balance;

    }
}
