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
        private int highScore;

        public override void initializeDB()
        {
            // Create Text File
            Stream fs = File.Open(filename, FileMode.OpenOrCreate);
            // Load Scores
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                scores = (List<int>) bFormatter.Deserialize(fs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception!");
                scores = new List<int>();
            }
            if (scores == null)
            {
                Console.WriteLine("list is null");
                scores = new List<int>();
            }
            Console.WriteLine("printing list");
            foreach (int x in scores)
            {
                Console.WriteLine("x:");
                Console.WriteLine(x);
            }
            try
            {
                highScore = scores.Max();
            }
            catch (Exception ex)
            {
                highScore = 0;
            }
            Level.unlockLevels(highScore);
            fs.Close();
        }

        public override void addScore(int Score) {
            // Add to scores array
            scores.Add(Score);
            // Update highscore
            if (Score > highScore) { highScore = Score; }
            // Write to file
            Stream fs = File.Open(filename, FileMode.OpenOrCreate);
            Console.WriteLine("writing to file");
            BinaryFormatter bFormatter = new BinaryFormatter();
            foreach (int x in scores)
            {
                Console.WriteLine("x:");
                Console.WriteLine(x);
            }
            bFormatter.Serialize(fs, scores);
            fs.Close();
        }

        public override List<int> getScores()
        {
            return scores;
        }

        public override int getHighscore()
        {
            return highScore;
        }

        public override void closeDB()
        {
            Console.WriteLine("Closing DB");
        }
    }
}
