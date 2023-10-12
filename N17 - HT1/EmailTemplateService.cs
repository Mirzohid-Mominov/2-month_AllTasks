namespace N17___HT1;


public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }
}



public class EmailTemplateService
{
    List<EmailTemplate> Templates { get; set; }

    public EmailTemplateService()
    {
        Templates = new List<EmailTemplate>();
    }


    public void Add(string subject, string content)
    {
        var template = new EmailTemplate { Subject = subject, Content = content };
        Templates.Add(template);
    }

    public string GetRegistrationTemplate(string username)
    {
        EmailTemplate template = Templates.Find(f => f.Subject == "Account Registration");

        string massage = template.Content.Replace(MassageConstants.UserToken, username);
        return massage;
    }

    public string GetAccountBlockedTemplate(string username)
    {
        EmailTemplate template = Templates.Find(f => f.Subject == "Account Blocked");

        string massage = template.Content.Replace(MassageConstants.UserToken, username);
        return massage;
    }

    public static class MassageConstants
    {
        public const string UserToken = "{{UserToken}}";
    }


}
