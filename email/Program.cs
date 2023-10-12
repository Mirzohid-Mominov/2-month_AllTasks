Console.Write("Ism sharifingizni kiriting: ");
string[] arr = Console.ReadLine().Trim().Split(' ');


Random random = new Random();

var email = string.Empty;
//Bazada bor ismlar: Jasur Abdulhayev, Hasanboy DusmatoV, leonel Messi, John DOE, AsaD ASAdov;
string[] addEmail = new string[] { "tesha", "bolta", "kosmonavt", "somsa", "tilla" };
string[] oldEmail = new string[] { "jasurabdulhayev@gmail.com", "hasanboydusmatov@gmail.com", "holibekumarov@gmail.com","muqimbekteshaboy@gmail.com",
                                    "leonelmessi@gmail.com", "johndoe@gmail.com", "asadasadov@gmail.com"};

string newemail = "";
foreach (var i in arr)
{
    foreach (var j in i.Trim())
    {
        if (j >= 'A' && j <= 'Z' || j >= 'a' && j <= 'z')
        {
            newemail += j.ToString().ToLower();
        }
    }
}
newemail += "@gmail.com";
const string Digits = "0123456789";
const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";

for (int i = 0; i < oldEmail.Length; i++)
{
    if (newemail.Contains(oldEmail[i]))
    {
        newemail = newemail.Insert(0, addEmail[random.Next(oldEmail.Length - 1)] + '-'+
            Digits[random.Next(Digits.Length)].ToString()+
            SpecialCharacters[random.Next(SpecialCharacters.Length)].ToString());
        break;
    }
}

Console.WriteLine($"New email: {newemail}");