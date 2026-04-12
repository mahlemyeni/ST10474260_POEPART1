using System;
using System.Media;

public class AudioPlayer
{
    public void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch (Exception)
        {
            Console.WriteLine("(Audio file not found or failed to play.)");
        }
    }
}