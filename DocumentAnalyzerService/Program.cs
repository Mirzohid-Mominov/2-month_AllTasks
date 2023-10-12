
//Document Analyzer - Essay analiz qiladigan dastur tuzing. Boshlang'ich 100 ball bilan boshlab, har bitta xato uchun quyidagicha minus qilib borasiz

//- essay uchun Document modelidan foydalanilsin
//- Document modelida Content ma'lumoti bo'lsin
//- analiz uchun DocumentAnalyzer servicedan foydalanilsin
//- unda analiz methodi bo'lsin, u essay ni Document tipida qabul qilib, hisoblangan ballni int tipida qaytarsin

//Analiz jarayoni quyidagicha
//- Berilgan jumlani xohlagancha qismlarga ajrating ( gap, so'z va hk ) va quyidagilarni tekshiring
//- Umumiy so'zlar soni 500 dan kam bo'lsa - 5 ball
//- Xohlagan bitta so'z takrorlanishi umumiy so'zlar sonini 20% dan ko'pini tashkil qilsa - 5 ball
//- Gapda 1-so'z capital bo'lmasa - 5 ball
//- Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
//- Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball

//- Analyze methodiga text o'rniga file filePath beriladigan bo'lsin
//- Analyze va unga yordamchi barcha methodlar asinxron ishlasin
//- dasturda DocumentAnalyzerService dan instance oling va 10 ta faylga text joylab, natijalarini ekranga chiqaring

//Example :

//Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!

//So'zlar soni 500 dan kamligi uchun : -5
//Capital bo'lmagan birinchi so'zlar uchun ( quaerat ) : -5
//Birinchi so'z bo'lmagan va faqat kichik harflar bilan yozilmagan so'zlar uchun ( QUIDEM ) : -10

//Rezultat - 80 ball
//DocumentAnalyzerService ga quyidagi o'zgarishlar kiriting


using DocumentAnalyzerService_30_HT1;


class Program
{
    public static async Task Main()
    {
        string path = @"D:\All_Homework\Essay.txt";
        var filePlace = new FileInfo(Convert.ToString(path));

        // Create a file to write to.
        using (StreamWriter fileName = filePlace.CreateText())
        {
            fileName.WriteLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!\r\n");

        }

        var essayAnalyzer = new DocumentAnalyzer();

        var score = await essayAnalyzer.Analyze(path);
        Console.WriteLine($"Score : {score}");
    }
}