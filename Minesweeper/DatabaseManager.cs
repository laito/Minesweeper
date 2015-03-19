using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class DatabaseManager
    {
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

        internal DatabaseManagerFactory DatabaseManagerFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public abstract void initializeDB();
        public abstract void addScore(int Score);
        public abstract int[] getScores();
        public abstract int getHighscore();
    }
}
