using System.Diagnostics.Metrics;

namespace N14_HT1;

internal class NotificationMessages
{
    private Dictionary<string, string> massages = new Dictionary<string, string>();


    public NotificationMessages() 
    {
        massages.Add("SuccessRegistration", "You successfully registrated");
        massages.Add("AskPassword", "Enter your password");
        massages.Add("Blockes", "Your account has been blocked");
    }

    protected KeyValuePair<string, string> FindMessage(string messageName)
    {

        foreach (var pair in massages.Keys)
            if (pair.ToLower() == messageName.ToLower())
                return new KeyValuePair<string, string>(pair, massages[pair]);
        return new KeyValuePair<string, string>();
    }


    public string SearchMassage(string messageName)
    {
        KeyValuePair<string, string> messagePair = FindMessage(messageName);
        if (!string.IsNullOrEmpty(messagePair.Key))
        {
            return messagePair.Value;
        }
        else
        {
            return "Message not found";
        }
    }

}
