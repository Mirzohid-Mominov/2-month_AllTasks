using System.Text;

namespace N13___HT2;

public class SecurePasswordGenerator : PasswordGenerate
{

    public SecurePasswordGenerator(int length, bool hasLetters, bool hasDigits = false)
        : base(length, hasLetters, hasDigits)
    {

    }


    public string Generate(bool hasSymbols)
    {
        const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        const string chars = "!@#$%^&*()_+=*~/\\][}{|:'\";.<>,?";


        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < Length; i++)
        {
            if (!HasDigits || !HasLetters || !hasSymbols)
                return "Tuzb bo'lmaydi!";

            int index;
            if (HasLetters && sb.Length < Length)
            {
                index = rnd.Next(letters.Length);
                sb.Append(letters[index]);

            }
            if (HasDigits && sb.Length < Length)
            {
                index = rnd.Next(digits.Length);
                sb.Append(digits[index]);
            }
            if (hasSymbols && sb.Length < Length)
            {
                index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

        }

        return sb.ToString();
    }



}
