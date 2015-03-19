using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class TextFileManager : DatabaseManager
    {
        private String filename;

        public override void initializeDB()
        {
            // Create Text File
            // Load Scores
        }

        public override void addScore(int Score) {

        }

        public override int[] getScores()
        {
            return null;
        }

        public override int getHighscore()
        {
            return 0;
        }
    }
}
