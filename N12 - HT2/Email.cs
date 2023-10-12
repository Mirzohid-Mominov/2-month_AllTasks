using System.Text.RegularExpressions;

namespace N12___HT2;

public class Email
{
    public string To
    {
        get
        {
            return To;
        }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var emailAdressRegex = new Regex(pattern);

            if (emailAdressRegex.IsMatch(value))
            {
                Console.WriteLine($"{value} => Valid email");
            }
            else
            {
                throw new FormatException("Invalid email");
            }
        }
    }

    public string From
    {
        get
        {
            return From;
        }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var emailAdressRegex = new Regex(pattern);

            if (emailAdressRegex.IsMatch(value))
            {
                Console.WriteLine($"{value} => Valid email");
            }
            else
            {
                throw new FormatException("Invalid email");
            }

        }
    }
    public string Subject
    {
        get => Subject;
        set
        {
            if (!(value is null) && !string.IsNullOrWhiteSpace(value))
            {
                String[] arr = value.Split(" ");
                if (arr.Length > 3)
                {
                    Console.WriteLine($"{value} => Valid text");
                }
                else
                    throw new FormatException("Invalid Subject");
            }
            else
                throw new FormatException("Invalid Subject");
        }
    }
    public string Content
    {
        get => Content;
        set
        {
            if (!(value is null) && !string.IsNullOrWhiteSpace(value))
            {
                String[] arr = value.Split(" ");
                if (arr.Length > 3)
                {
                    Console.WriteLine($"{value} => Valid text");
                }
                else
                    throw new FormatException("Invalid Content");
            }
            else
                throw new FormatException("Invalid Content");
        }
    }

    public override string ToString()
    {
        // CHiroyli chiqarishga sali chunmadim shartiga
        return $"To: {To}\nFrom: {From}\nSubject: {Subject}\nContent: {Content}";
    }
















}
