using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//MusicService abstract serivcedan dan foydalaning
//- virtual SwitchNext -keyingi qo'shiqqa o'tkazish
//- virtual SwitchPrevious - oldingi qo'shiqqa o'tkazish
//- virtual DisplayCurrentSong - hozirgi qo'shiqni ekranga message bilan chiqarish
//- abstract Add(name, singerName) - qo'shiqni saqlab qo'yish


namespace ServicePolymorphism_T4
{
    abstract class MusicService
    {
        List<Music> musics = new List<Music>
        {
            new Music("Upbeat Groove", "Energetic and lively instrumental track."),
            new Music("Dreamy Melodies", "Soothing and ambient soundscape for relaxation."),
            new Music("Funky Rhythms", "Catchy funk-inspired music with groovy basslines."),
            new Music("Epic Adventure", "Orchestral composition conveying a sense of grand adventure."),
            new Music("Chill Vibes", "Laid-back electronic beats perfect for unwinding."),
            new Music("Rock Anthem", "Powerful rock song with strong guitar riffs."),
            new Music("Mystical Journey", "Enigmatic and mysterious soundtrack for a journey."),
            new Music("Dancefloor Heat", "High-energy dance track to get the party going."),
            new Music("Piano Serenity", "Gentle piano piece evoking feelings of peace."),
            new Music("Sci-Fi Odyssey", "Futuristic and spacey music for a science fiction atmosphere."),
            new Music("Country Roads", "Country-style acoustic tune celebrating rural life."),
            new Music("Romantic Whispers", "Passionate and romantic orchestral arrangement."),
            new Music("Urban Pulse", "Modern urban sounds with a pulsating electronic beat."),
            new Music("Magical Fantasy", "Whimsical and magical theme for fantasy worlds."),
            new Music("Latin Grooves", "Lively Latin-inspired music with rhythmic percussion."),
            new Music("Emotional Resonance", "Music that tugs at the heartstrings."),
            new Music("Jazzy Nights", "Smooth jazz composition for a relaxing evening."),
            new Music("Industrial Grit", "Heavy and intense music with industrial undertones."),
            new Music("Youthful Energy", "Energetic pop track capturing youthful spirit."),
            new Music("Ancient Legends", "Orchestral piece inspired by ancient myths and legends.")
        };

        public void Main(int button)
        {
            Console.WriteLine("If you tup the 6\nYou can change NEXT\n" +
                "If you tup the 6\nYou can change Previous\n" +
                "If you tup 5\nWe can show wich music you are listening now\n" +
                "And also if you tup 8\nYou can save your surrent music your Playlist");
            
            

            for(int i = 0; i < musics.Count; i++)
            {
                button = int.Parse(Console.ReadLine());

                if (button == 6)
                {
                    Console.WriteLine(musics[i + 1]);
                }
                if(button == 4)
                {
                    Console.WriteLine(musics[i-1]);
                }
                if(button == 5)
                {
                    Console.WriteLine($"Music's name  : {musics[i]}");
                }
                else if(button == 8)
                {
                    musics.Add(musics[i]);
                }
            }
        
        
        }
    }
}
