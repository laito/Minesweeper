using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class DatabaseManager
    {

        public DatabaseManager()
        {
            initializeDB();
        }

        public abstract void initializeDB();
        public abstract void closeDB();
        public abstract void addScore(int Score);
        public abstract List<int> getScores();
        public abstract int getHighscore();
    }
}
