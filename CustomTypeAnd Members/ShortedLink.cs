using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//N32-T1 - custom type and members

//- ShortenedLink modelidan foydalaning ( id, originalUrl, shortenedUrl ) 
//-undan bir nechta object yarating, tengligini tekshiring


namespace CustomTypeAnd_Members
{
    internal class ShortedLink
    {
        public ShortedLink(string originalUrl, string shortnedUrl)
        {
            Id = new Guid();
            OriginalUrl = originalUrl;
            ShortnedUrl = shortnedUrl;
        }

        public Guid Id { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortnedUrl { get; set; }
    }
}
