namespace N18___T1;

internal class Program
{
    static void Main(string[] args)
    {
        Malibu car1 = new Malibu("Malibu Turbo", 2022, "Qora", 280, 5);
        //car1.Show();
       

        Captiva car2 = new Captiva("Captiva3", 2020, "Oq", 300, 5);
        //car2.Show();
        


        Thread thread = new Thread(car1.Drive);
        Thread thread1 = new Thread(car2.Drive);

        thread.Start();
        thread1.Start();

        thread.Join();
        thread1.Join();
    }
}