namespace DocumentAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var d = new document()
            {
                content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!",
            };

            var da = new DocumentAnalyzer();
            Console.WriteLine($"{da.Analiz(d)}");

        }

        public class document
        {
            public string content;
        }


        public class DocumentAnalyzer
        {
            public int Analiz (document matn)
            {
                var ball = 100;

                // 500 sozga teksghiradi
                string[] arr = matn.content.Split(' ');
                if (arr.Length < 500)
                {
                    Console.WriteLine("Umumiy so'zlar soni 500 dan kam bo'lsa - 5 ball");
                    ball -= 5;
                }
                string[] newArr = arr.Distinct().ToArray();

                // Takrorlanishi 20 foizdan kop bolsa -5
                for (int i = 0; i < newArr.Length - 1; i++)
                {
                    int sana = 0;
                    for (int j = 0; j < arr[i].Length - 1; j++)
                    {
                        if (newArr[i].Trim().Contains(arr[j]))
                        {
                            sana += 1;
                        }
                    }
                    if (sana < arr.Length /100 * 20F)
                    {
                        Console.WriteLine("Xohlagan bitta so'z takrorlanishi umumiy so'zlar sonini 20% dan ko'pini tashkil qilsa - 5 ball");
                        ball -= 5;
                        break;
                    }
                }

                string[] gaplar = new string[1000];
                gaplar = matn.content.Split('.', '!', '?');
                //Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
                for (int i = 0; i < gaplar.Length - 1; i++)
                {
                    var s = gaplar[i].Trim();
                    var str = string.Concat(s.Substring(0, 1)
                    .ToUpper(), s.Substring(1).ToLower());
                    if (s != str)
                    {
                        Console.WriteLine("Gapda 1-so'z capital bo'lmasa - 5 ball");
                        ball -= 5;
                    }

                    var word = s.Split(' ');
                    if (word.Length >= 20)
                    {
                        Console.WriteLine("Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball");
                        ball -= 20;
                    }

                    for (int j=1; j<word.Length-1; j++)
                    {
                       
                        if (word[j].ToUpper() == word[j])
                        {
                            Console.WriteLine("Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball");
                            ball -= 10;
                        }
                    }

                }





                return ball;
            }
        }
    }
}