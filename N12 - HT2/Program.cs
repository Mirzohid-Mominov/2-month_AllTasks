using System.ComponentModel.DataAnnotations;

namespace N12___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        Email email = new Email();

        email.To = "jasurabdulxaev@gmail.com"; // Valid Email
       // email.To = "kas @@@ .gmail.com";       // Invalid Email

        email.From = "johnDoe333@gmail.com"; // Valid Email
       // email.From = "s @@ .gmail.com";       // Invalid Email

        email.Subject = "John Doe G'ishmat Toshmat, Bob"; // Valid Subject
        //email.Subject = "Toshmat"; // Invalid Subject - 3 ta sozdan kopligi hisobga olingan

        email.Content = "Hello World, lets C# Coding"; // Valid Content
        email.Content = "   "; // Invalid Content - 3 ta sozdan kopligi hisobga olingan


    }
}