
internal class Program
{
    static void Main(string[] args)
    {
        ChatServise chatServise = new ChatServise();

        var id1 = chatServise.ADD("Salom Hammaga!");
        var id2 = chatServise.ADD("Darsni boshlaymizmi?");
        var id3 = chatServise.ADD("20 minutda boshlaymiz");
      
        chatServise.Update(id2, "Bugun dars bo'lmaydi!");
        chatServise.Update(id3, "Ertaga Juma!!! ");

        chatServise.Display();
    }
}      