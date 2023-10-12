namespace N13___HT2;

public class UniquePasswordGenerate : SecurePasswordGenerator
{
    public UniquePasswordGenerate(int length, bool hasLetters, bool hasDigits = false)
        : base(length, hasLetters, hasDigits)
    {

    }

    List<string> results = new List<string>();
    public string GenerateUniqePassword()
    {

        while (true)
        {
            string parol = Generate();
            if (!results.Contains(parol))
            {
                results.Add(parol);
                return parol;
            }
            
        }

        
    }
}
