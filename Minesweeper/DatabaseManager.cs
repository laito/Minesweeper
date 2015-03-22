using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class DatabaseManager
    {

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
        public abstract List<int> getScores();
        public abstract int getHighscore();
    }
}
