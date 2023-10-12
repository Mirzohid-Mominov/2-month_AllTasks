using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


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

//- Analyze methodiga text o'rniga file path beriladigan bo'lsin
//- Analyze va unga yordamchi barcha methodlar asinxron ishlasin
//- dasturda DocumentAnalyzerService dan instance oling va 10 ta faylga text joylab, natijalarini ekranga chiqaring

//Example :

//Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!

//So'zlar soni 500 dan kamligi uchun : -5
//Capital bo'lmagan birinchi so'zlar uchun ( quaerat ) : -5
//Birinchi so'z bo'lmagan va faqat kichik harflar bilan yozilmagan so'zlar uchun ( QUIDEM ) : -10

//Rezultat - 80 ball
//DocumentAnalyzerService ga quyidagi o'zgarishlar kiriting


namespace DocumentAnalyzerService_30_HT1
{
    internal class DocumentAnalyzer
    {
        public string Content { get; set; }
        public int Result { get; set; }

        public async Task<int> Analyze(string filePath)
        {
            Result = 100;
            Content = File.ReadAllText(filePath);

            await AllWordsCount();
            await WordsRepeatingCheck();
            await WordsCheckCapitalLetter();
            await WordsCheckLoweLetter();
            await WordsCheckLength();
            return Result;
        }

        //- Umumiy so'zlar soni 500 dan kam bo'lsa - 5 ball
        public async Task AllWordsCount()
        {
            if (Content.Split(' ').Length < 500)
                Result -= 5;
        }

        //- Xohlagan bitta so'z takrorlanishi umumiy so'zlar sonini 20% dan ko'pini tashkil qilsa - 5 ball
        public async Task WordsRepeatingCheck()
        {
            var words = Content.Split(' ');

            foreach (string word in words)
            {
                var count = words.Count(x => string.Equals(x, word));

                if ((count / words.Length) * 100 >= 20)
                {
                    Result -= 5;
                }
            }
        }

        //- Gapda 1-so'z capital bo'lmasa - 5 ball
        public async Task WordsCheckCapitalLetter()
        {
            var checkingSentences = Content.Split('.', '?', '!');

            foreach (string word in checkingSentences)
            {
                var words = word.Trim().Split();
                var lastWord = words[0];

                if (lastWord != string.Concat(lastWord.Substring(0, 1).ToUpper(), lastWord.Substring(1).ToLower()))
                {
                    Result -= 5;
                    return;
                }
            }
        }

        ////- Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
        public async Task WordsCheckLoweLetter()
        {
            var checkingSentences = Content.Split('?', '!', '.');

           foreach (string word in checkingSentences)
            {
                var words = word.Trim().Split();
                
                for (var i = 1; i < words.Length; i++)
                {
                    var firstWord = words[i];

                    if (firstWord != firstWord.ToLower())
                        Result -= 10;
                }
            }
        }

        ////- Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball
        public async Task WordsCheckLength()
        {
            var words = Content.Split();
            var count = words.Count(word => word.Length >= 20);
            Result -= (count) * 10;
        }
    }
}


