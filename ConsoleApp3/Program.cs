namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            for (int i = 0; i < 100_000; i++) 
            {
                str += "yoki undan ortiq satrlarni birlashtirganda yangi satr ishlab chiqariladi.\r\n\r\nNominatsiyalar 2024 yilda IT sohasida ishlash uchun eng yaxshi joylar uchun ochiq\r\nBiroq, string C# da o'zgarmas tur bo'lsa, StringBuilder o'zgaruvchan elementga misoldir. C# da StringBuilder - bu o'zgaruvchan belgilar seriyasidir, agar kerak bo'lsa, ko'proq belgilarni saqlash uchun kengaytirilishi mumkin. Satrlardan farqli o'laroq, StringBuilder misolini o'zgartirish xotirada yangi namunani yaratishga olib kelmaydi.\r\n\r\nAgar satrni o'zgartirmoqchi bo'lsangiz, Common Language Runtime noldan yangi satr hosil qiladi va eskisini bekor qiladi. Shunday qilib, agar siz satrga bir qator belgilar qo'shsangiz, bir xil satrni xotirada bir necha marta qayta yaratasiz. Aksincha, StringBuilder klassi bufer maydoni uchun xotira ajratadi va keyin yangi belgilarni to'g'ridan-to'g'ri buferga yozadi. Ajratish faqat bir marta amalga oshiriladi.\r\n\r\nQuyidagi ikkita usulni ko'rib chiqing:";
                Console.WriteLine(str);
            }

        }
    }
}