
//N29 - HT1

//- user name larni bitta listda saqlang 
//- shu listda username lar uchun asinxron ravishda fayllar yarating
//- har bitta fayl yaratib bo'lingach ekranga ${username} uchun fayl yaratildi" xabari chiqsin


List<string> _users = new List<string>()
    {
        "Azizibek",
        "Qulpiddin",
        "Halima",
        "Salima"
    };

var result = _users.Select( x => Task.Run(() =>
{
    File.Create(x);
    Console.WriteLine(x + " uchun file yaratildi");
}));


await Task.WhenAll(result);