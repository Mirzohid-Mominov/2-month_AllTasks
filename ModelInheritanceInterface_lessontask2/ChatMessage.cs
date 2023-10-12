using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-ChatMessage modelidan foydalaning(id, subject, message, chatId )

namespace ModelInheritanceInterface_lessontask2
{
    internal class ChatMessage : AuditableEntity
    {
        public ChatMessage(string subject, string message, int chatId)
        {
            Id = new Guid();
            Subject = subject;
            Message = message;
            ChatId = chatId;
        }

        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int ChatId { get; set; }

        public override string ToString()
        {
            return $"Subject : {Subject}\tMessage : {Message}";

        }
        public override int GetHashCode()
        {
            // 17 va 23 siz GetHashCode ni qiymati mana bunday bo'lur

            // Alex   23 yosh              23423234
            // Alexa  23 yosh              23424234


            // 17 va 23 bilan GetHashCode ni qiymati mana bunday bo'lur

            // Alex   23 yosh              23423234
            // Alexa  23 yosh              53277428

            var hash = 17;
            hash = hash * 23 + Subject.GetHashCode();
            hash = hash * 23 + Message.GetHashCode();
            hash = hash * 23 + Message.GetHashCode();

            return hash;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}
