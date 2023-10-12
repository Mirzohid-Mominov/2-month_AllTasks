using System.Net.Mail;
using System.Net;

namespace N16___T1;

public class EmailService
{
    public string CredentialAddres { get; init; }
    public string CredentialPassword { get; init; }


    public EmailService(string credentialAddres, string credentialPassword)
    {
        CredentialAddres = credentialAddres;
        CredentialPassword = credentialPassword;
    }


    public void SendEmail(string to, string userName)
    {
        var mail = new MailMessage(CredentialAddres, to);
        mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
        mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}", userName);

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(CredentialAddres, CredentialPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }







}