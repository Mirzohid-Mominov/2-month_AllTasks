namespace TestDasturi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // questions and answers are created
            var questions = new[] { "O'zbekistonni poytaxti qayer?", "Qaysi guruhni vazifasini tekshiryabsiz?",
                "Kimni vazifasini tekshiryabsiz?", "2+2*2 qiymati necha?", "Dasturchilar 'Windows' uradimi ?" };
            string[,] answers = new[,] { {"Moscow", "Tashkent"}, {  "N10","N13" },
                { "Jasur Abdulhayev", "Azizbek Abdurahmonov" }, { "8", "6"}, { "Albatta :)", "No bruh!"} };


            var trueAnswers = new string[5] { "Tashkent", "N10", "Jasur Abdulhayev", "6", "No bruh!" };
            var userAnswers = new string[5];
            var wrongAnswers = new string[10];


            int count = 0, k = 0;
            Console.WriteLine("Welcome Our Test!\n");
            Thread.Sleep(500);

            for (int i = 0; i < questions.Length; i++)
            {
            abs:
                Console.WriteLine(questions[i]);
                Console.WriteLine($"A) {answers[i, 0]}");
                Console.WriteLine($"B) {answers[i, 1]}");
                Console.Write("User: ");
                string javob = Console.ReadLine();

                //CHECKING TRUE ANSWER
                if (javob[0].ToString().ToUpper() == "A" && javob.Length == 1)
                {
                    if (trueAnswers[i] == answers[i, 0])
                        count++;
                    else
                    {
                        wrongAnswers[k] = questions[i];
                        wrongAnswers[k + 1] = trueAnswers[i];
                        k += 2;
                    }
                }   
                else if (javob[0].ToString().ToUpper() == "B" && javob.Length == 1)
                {
                    if (trueAnswers[i] == answers[i, 1])
                        count++;
                    else
                    {
                        wrongAnswers[k] = questions[i];
                        wrongAnswers[k + 1] = trueAnswers[i];
                        k += 2;
                    }
                }
                else
                {
                    // A-a yoki B-b dan boshqa narsa kiritilsa qaytadan so'rov yuboriladi!
                    Console.WriteLine("Xato variant kiritildi!\n'A', 'a' yoki 'B', 'b' variantlardan birini kiritishingizni so'raymiz!\n");
                    goto abs;
                }
            }

            Thread.Sleep(500);
            Console.WriteLine("\n");
            Console.WriteLine($"To'g'ri javoblar soni: {count}\n");

            if (wrongAnswers.Length != 0)
            {
                Console.WriteLine("Xato bajargan testlaringiz:\n");
                for (int i = 0; i < wrongAnswers.Length; i += 2)
                {
                    if (wrongAnswers[i] is not null)
                        if (wrongAnswers[i].Length != 0)
                        {
                            Console.WriteLine(wrongAnswers[i]);
                            Console.WriteLine("True answer: " + wrongAnswers[i + 1] + "\n");
                        }
                }
            }
        }
    }
}