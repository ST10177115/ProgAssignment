using System;
using System.Media;
using System.Collections.Generic;
using System.Text;

namespace ProgAssignment
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            SoundPlayer player = new SoundPlayer("greeting.wav.wav");
            player.PlaySync();
        }
    }
}

