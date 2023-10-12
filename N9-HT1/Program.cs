using System.Net.Mail;
using System.Text.RegularExpressions;

namespace N9_HT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
            list.Add("ma12@hostname.com");
            list.Add("js#internal@proseware.com");
            list.Add("A@b@c@example.com");
            list.Add("david.jones@proseware.com");
            list.Add("MA@hos tname.coMCom");

            // 1- usul
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var emailAdressRegex = new Regex(pattern);
            foreach (string item in list)
            {
                if (emailAdressRegex.IsMatch(item))
                {
                    Console.WriteLine($"{item} => Valid");
                }
                else
                {
                    Console.WriteLine($"{item} => Invalid");
                }
            }


            // 2-Usul
            /*foreach (string s in list)
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(s);
                    Console.WriteLine($"{s} => Valid");
                }
                catch
                {
                    Console.WriteLine($"{s} => Invalid");
                }
            }*/


        }
    }
}