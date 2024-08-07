namespace DesignPatternsDotnet8.Adapter;

// Let's say you have a media player application that plays audio files.
// The application is designed to work with an interface IMediaPlayer that has a Play method.
// However, you have a legacy music player class that uses a different interface,
// LegacyPlayer, with a method called PlayTrack.


// The target interface
public interface IMediaPlayer
{
    void Play(string filename);
}

// The legacy class with an incompatible interface
public class LegacyPlayer
{
    public void PlayTrack(string track)
    {
        Console.WriteLine($"Playing track: {track}");
    }
}

// To make the LegacyPlayer class work with the IMediaPlayer interface,
// you can create an adapter class that implements IMediaPlayer and internally uses a LegacyPlayer object.
public class MediaPlayerAdapter : IMediaPlayer
{
    private readonly LegacyPlayer _legacyPlayer;

    public MediaPlayerAdapter(LegacyPlayer legacyPlayer)
    {
        _legacyPlayer = legacyPlayer;
    }

    public void Play(string filename)
    {
        // Convert the filename to the format expected by the LegacyPlayer
        _legacyPlayer.PlayTrack(filename);
    }
}