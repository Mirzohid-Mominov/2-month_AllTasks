namespace N11_HT2;

internal class Program
{
    static void Main(string[] args)
    {
        MusicPlayer player = new MusicPlayer();

        player.AddTrack("Bohemian Rhapsody", "Queen");
        player.AddTrack("Stairway to Heaven ", "Led Zeppelin");
        player.AddTrack("Imagine", "John Lennon");
        player.AddTrack(" Smells Like Teen Spirit", "Nirvana");


        while (true)
        {
            Console.WriteLine("Choose a command (next - n / previous - p / pause - pa / play - pl / exit - x)");
            string command = Console.ReadLine().ToLower();

            if (command == "n")
            {
                player.Next();
            }
            else if(command == "p") 
            { 
                player.Previous();
            }
            else if(command == "pa") 
            { 
                player.Pause();
            }
            else if( command == "pl")
            {
                player.Play();
            }
            else if(command == "x")
            {
                Console.WriteLine("Thank you for using the program");
                return;
            }
            else 
            {
                Console.WriteLine("Invalid command");
            }


        }

    }
}