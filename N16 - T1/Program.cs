namespace N16___T1;

internal class Program
{
    static void Main(string[] args)
    {
        EmailService email = new EmailService("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");

        Console.WriteLine("Enter your email address: ");
        var emailAddress = Console.ReadLine();

        Console.WriteLine("Enter your userName:");
        var userName = Console.ReadLine();

        email.SendEmail(emailAddress, userName);

    }
}