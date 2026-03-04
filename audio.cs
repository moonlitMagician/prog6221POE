using System;
using System.Media;

namespace AudioNamespace
{
    public class Audio
    {

        private static SoundPlayer? _player;
        public static void PlayGreeting()
        {
            try
            {
                _player = new SoundPlayer("greetingconv.wav");
                _player.Play();

            }catch(Exception e)
            {
                Console.WriteLine($"Error playing audio: {e.Message}");
            }
        }

    }
}