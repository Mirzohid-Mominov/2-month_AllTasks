namespace N17___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        EmailTemplateService service = new EmailTemplateService();

        service.Add("Account Registration", "Hurmatli {{UserToken}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
        service.Add("Account Blocked", "Hurmatli {{UserToken}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");


        string registrationMassage = service.GetRegistrationTemplate("Jasurbek");
        string blockedMassage = service.GetAccountBlockedTemplate("Bob");

        Console.WriteLine($"Registratsiya habar: {registrationMassage}\n");
        Console.WriteLine($"Bloklangan habar: {blockedMassage}\n");






    }
}