using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Music modelidan foydalaning ( id, name, singerName )

    
namespace ServicePolymorphism_T4
{
    internal class Music
    {
        public Music(string name, string description)
        {
            Id = new Guid();
            Name = name;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
