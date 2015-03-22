using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Minesweeper
{
    class TextFileManager : DatabaseManager
    {
        private String filename = "db.txt";
        private List<int> scores;
        FileStream fs;
        private int highScore;

        public override void initializeDB()
        {
            // Create Text File
            fs = new FileStream(filename, FileMode.Append, FileAccess.ReadWrite, FileShare.Read);
            // Load Scores
            BinaryFormatter bFormatter = new BinaryFormatter();
            scores = (List<int>) bFormatter.Deserialize(fs);
            highScore = scores.Max();
        }

        public override void addScore(int Score) {
            // Add to scores array
            scores.Add(Score);
            // Update highscore
            if (Score > highScore) { highScore = Score; }
            // Write to file
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(fs, getScores());
        }

        public override List<int> getScores()
        {
            return scores;
        }

        public override int getHighscore()
        {
            return highScore;
        }
    }
}
