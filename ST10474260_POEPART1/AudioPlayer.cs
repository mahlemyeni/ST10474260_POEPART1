using System;
using System.Media;
using System.IO;

public class AudioPlayer
{
    // Plays a welcome voice message
    public void PlayGreeting()
    {
        try
        {
            string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
            if (File.Exists(soundFilePath))
            {
                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    player.PlaySync(); // Play the sound synchronously
                }
            }
            else
            {
                // Output error message if the sound file is missing
                Console.WriteLine($"[ERROR] greeting.wav not found at: {soundFilePath}");
                Console.WriteLine("[System] Welcome voice file missing. Text-only mode active.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Failed to play greeting: {ex.Message}");
        }
    }
}
