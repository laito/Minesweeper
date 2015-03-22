using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace Minesweeper
{
    class SoundManager
    {
        private String backgroundMusicFile = "";
        private String winAudio = "";
        private String loseAudio = "";
        private SoundPlayer player;

        public SoundManager()
        {
            player = new System.Media.SoundPlayer("theme.wav");
            playBackgroundMusic();
        }

        public void playBackgroundMusic()
        {
            player.PlayLooping();
        }

        public void playSound(String eventOccurred) 
        {
            // Play sound on the basis of event 
            if (eventOccurred.Equals("win"))
            {
                player.Stop();
                player.SoundLocation = "win.wav";
                player.PlayLooping();
            }
            else if (eventOccurred.Equals("lose"))
            {
                player.Stop();
                player.SoundLocation = "lose.wav";
                player.PlayLooping();
            }
        }
    }
}
