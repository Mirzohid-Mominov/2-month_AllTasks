

internal class ChatServise
{
    private List<ChatMessage> Messages;

    public ChatServise()
    {
        Messages = new List<ChatMessage>();

    }

    // Add method
    public int ADD(string content)
    {
        if (MassageValidator.IsValidMassage(content))
        {
            int id = Messages.Count + 1;
            ChatMessage newMessage = new ChatMessage(id, DateTime.Now, content);
            Messages.Add(newMessage);
            return id;
        }
        else
        {
            throw new Exception("Invalid massage content!");
        }
    }

    //Update method
    public void Update(int id, string content)
    {
        ChatMessage mavjudXabar = Messages.Find(k => k.Id == id);

        if(mavjudXabar != null)
        {
            if(MassageValidator.IsValidMassage(content))
            {
                ChatMessage updateMassage = new ChatMessage(mavjudXabar);
                updateMassage.Content = content;
                Messages.Add(updateMassage);
            }
            else
            {
                throw new Exception("Invalid massage content!");
            }
        }
        else
        {
            throw new Exception($"Massage with Id {id} not found");
        }
    }

    public void Display()
    {
        foreach(ChatMessage message in Messages) 
        {
            string displayMassage = message.Content;
            if(message.ChangedTime != DateTime.MinValue)
            {
                displayMassage += "  - Edited on  " + message.ChangedTime.ToString("dd.MM.yyyy HH:mm");
                
            }
            Console.WriteLine(displayMassage);
        }
    }

    // Validate method
    public static class MassageValidator
    {
        public static bool IsValidMassage(string content)
        {
            return !string.IsNullOrWhiteSpace(content);
        }
    }



}
