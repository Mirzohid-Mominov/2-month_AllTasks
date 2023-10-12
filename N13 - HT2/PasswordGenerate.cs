using System.Text;

namespace N13___HT2;

public class PasswordGenerate
{
    public int Length;
    public bool HasLetters;
    public bool HasDigits;

    public PasswordGenerate(int length, bool hasLetters, bool hasDigits = false)
    {
        Length = length;
        HasLetters = hasLetters;
        HasDigits = hasDigits;
       
    }

    public string Generate()
    {
        const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";


        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < Length; i++)
        {
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
            if(!HasDigits || !HasLetters)
                return "Tuzb bo'lmaydi!";
        }

        return sb.ToString();

    }


}
