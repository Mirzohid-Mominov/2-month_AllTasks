namespace HT4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ball = 100;
            string matn = "Lorem   ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi" +
                " quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur " +
                "voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum " +
                "similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis " +
                "voluptate maiores! Repellat,    dolorum!";

            string[] arr = matn.Split(' ');
            string[] newArr = new string[10000]; 
           
            // 500 ta so'zga tekshirish
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (!string.IsNullOrWhiteSpace(arr[i]))
                {
                    newArr[count] = arr[i];
                    count++;
                }
            }
            if(count < 500) 
                ball -= 5;

            //capital bo'lmagan so'zlar uchun -5
            string[] gaplar = matn.Split('.','!','?');

            for (int i = 0;i < gaplar.Length - 1; i++)
            {
                if (gaplar[i].Trim()[0] < 'A' || gaplar[i].Trim()[0] > 'Z')
                {
                    ball -= 5;
                    break;
                }
            }

            // Takrorlanishi 20 foizdan kop bolsa -5
            for (int i = 0;i < newArr.Length -1 ; i++) 
            {
                int sana = 0;
                for (int j = 0; j < newArr[i].Length-1; j++)
                {
                    if (newArr[i].Trim().Contains(arr[j]))
                    {
                        sana += 1;
                    }
                }
                if(sana > newArr.Length*0.2) 
                {
                    ball -= 5; 
                    break;
                }
            }

            //Gapda birinchi so'z bo'lmagan so'zlar faqat kichik harflar bilan yozilmagan bo'lsa - 10 ball
            for(int i = 0; i < gaplar.Length -1 ;i++)
            { 
                string[] soz = gaplar[i].Trim().Split(' ');
                for (int j = 1;j < soz.Length; j++)
                {
                    if (soz[j][0] < 'a' || soz[j][0] > 'z') 
                    {
                        ball -= 10;
                        break;
                    }
                }
            }

            //Gapda so'zlar uzunligi 20 dan oshib ketgan bo'lsa - 20 ball
            for (int i = 0; i < gaplar.Length - 1; i++)
            {
                string[] soz = gaplar[i].Trim().Split(' ');
                if (soz.Length > 20)
                {
                    ball -= 20;
                    break;
                }
            }

            Console.WriteLine($"Oxirgi to'plagan balingiz:{ball}");

        }
    }
}