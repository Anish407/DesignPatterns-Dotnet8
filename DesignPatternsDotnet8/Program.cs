// See https://aka.ms/new-console-template for more information

using DesignPatternsDotnet8.Adapter;

Adapter();


Console.WriteLine("Hello, World!");

void Adapter()
{
    LegacyPlayer legacyPlayer = new LegacyPlayer();
    IMediaPlayer mediaPlayer = new MediaPlayerAdapter(legacyPlayer);

// Now you can use the media player with the legacy player
    mediaPlayer.Play("song.mp3");
}