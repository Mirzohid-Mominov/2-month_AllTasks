using First_Or_Default_HT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- CrashReport modelidan foydalaning ( id, star, message, screenshot ) -IReview ni implement qilsin


namespace First_Or_Default_HT
{
    internal class CrashReport : IReview
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Message { get; set; }
        public string ScreenShot { get; set; }

        public CrashReport(int star, string message, string screenShot)
        {
            
            Star = star;
            Message = message;
            ScreenShot = screenShot;
        }

        public override string ToString() => $"Star(s): {Star}, Message: {Message}";
    }
}
