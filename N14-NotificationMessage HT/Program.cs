namespace N14_HT1;

internal class Program
{
    static void Main(string[] args)
    {
        NotificationMessages notificationMessages = new NotificationMessages();
        //var nimadur = notificationMessages.SearchMassage("Blockes"); // Valid message
        var nimadur = notificationMessages.SearchMassage("MCHS"); // Invalid message
        Console.WriteLine(nimadur);

        

    }
}