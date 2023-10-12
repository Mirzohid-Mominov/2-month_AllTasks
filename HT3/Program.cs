namespace N3_HT1;

public class Program
{
    static string generate(bool includeNumbers, bool includeLetters, bool includeSymbols, int passwordLength)
    {
        var random = new Random();
        var createPass = string.Empty;
        const string Letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        const string Digits = "0123456789";
        const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";

        while (true)
        {
            if (passwordLength <= 0)
                break;
            if (includeNumbers)
                createPass = createPass + Digits[random.Next(Digits.Length)];
            if (createPass.Length == passwordLength)
                break;
            if (includeLetters)
                createPass += Letters[random.Next(Letters.Length)];
            if (createPass.Length == passwordLength)
                break;
            if (includeSymbols)
                createPass += SpecialCharacters[random.Next(SpecialCharacters.Length)];
            if (createPass.Length == passwordLength)
                break;
        }
        return createPass;
    }

    static string check(string parol)
    {
        string xato = "";
        for (int i = 0; i < parol.Length; i++)
        {
            if ('A' >= parol[i] || parol[i] >= 'Z' && parol[i] <= 'a' || parol[i] >= 'z' && parol[i] != '@' && !char.IsDigit(parol[i]))
            {
                xato += parol[i];
            }
        }
        return xato;
    }


    static void Main(string[] args)
    {

        Console.Write("Need numbers (true/false): ");
        bool Numbers = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Need letters (true/false): ");
        bool Letters = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Need symbols (true/false): ");
        bool Symbols = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Password length: ");
        int passwordLength = Convert.ToInt32(Console.ReadLine());

        string parol = generate(Numbers, Letters, Symbols, passwordLength);
        Console.WriteLine($"Your genarate password is: {parol} ");


        Console.WriteLine(check(parol));
    }
}