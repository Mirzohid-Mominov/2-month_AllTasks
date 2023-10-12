namespace N11_HT2;

internal class MusicPlayer
{
    private List<Track> playlist;
    private int currentTrackIndex;

    public MusicPlayer()
    {
        playlist = new List<Track>();
        currentTrackIndex = 0;
    }

    public void AddTrack(string name, string author)
    {
        playlist.Add(new Track { Name = name, Author = author });
    }

    public void Next()
    {
        if (currentTrackIndex == playlist.Count - 1)
        {
            currentTrackIndex = 0;
            PlayCurrentTrack();
        }
        else
        {
            currentTrackIndex += 1;
            PlayCurrentTrack();
        }
    }

    public void Previous()
    {
        if (currentTrackIndex == 0)
        {
            currentTrackIndex = playlist.Count - 1;
            PlayCurrentTrack();
        }
        else
        {
            currentTrackIndex -= 1;
            PlayCurrentTrack();
        }
    }

    public void Play()
    {
        PlayCurrentTrack();
    }

    public void Pause()
    {
        Console.WriteLine($"Paused - {playlist[currentTrackIndex].Name}   Author: {playlist[currentTrackIndex].Author}");
    }

    private void PlayCurrentTrack()
    {
        Console.WriteLine($"Playing - {playlist[currentTrackIndex].Name}   Author: {playlist[currentTrackIndex].Author}");
    }


}
