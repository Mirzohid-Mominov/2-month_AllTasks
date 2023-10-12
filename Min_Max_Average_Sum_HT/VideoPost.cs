using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//- VideoPost modelidan foydalaning(id, title, description, likes, dislikes, topic )
//-VideoPost tipidagi listga 10 ta video qo'shing

namespace Min_Max_Average_Sum_HT
{
    internal class VideoPost
    {
        List<VideoPost> _videoPosts = new List<VideoPost>();

        public VideoPost(string description, string title, int likes, int disLikes, Topics topics)
        {
            Guid = new Guid();
            Description = description;
            Title = title;
            Likes = likes;
            DisLikes = disLikes;
            Topics = topics;
        }

        public Guid Guid { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public Topics Topics { get; set; }

        public override string ToString()
        {
            return $"{Title} {Description} {Likes} {DisLikes} {Topics}";
        }
    }
}
