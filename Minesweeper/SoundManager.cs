﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class SoundManager
    {
        private String backgroundMusicFile = "";
        private String winAudio = "";
        private String loseAudio = "";

        public SoundManager()
        {
            playBackgroundMusic();
        }

        public Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void playBackgroundMusic()
        {

        }

        public void playSound(String eventOccurred) 
        {
            // Play sound on the basis of event 
        }
    }
}