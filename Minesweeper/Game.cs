using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Game : Form
    {
        private static Counter timerCounter;
        private static Counter scoreCounter;
        private static Counter livesCounter;

        private int highScore;

        private static Grid Grid;
        private static GameSettings settings;
        private static DatabaseManager db;
        private static SoundManager soundManager;

        public Game()
        {
            InitializeComponent();
        }

        internal Grid Grid1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Smiley Smiley
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void gameLoad(object sender, EventArgs e)
        {
            initializeGame();
        }

        private void initializeGame()
        {
            //loadDatabase();
            //initializeSound();
            initializeSettings();
            initializeCounters();
        }

        private void initializeSettings()
        {
            settings = new GameSettings();
        }

        private void initializeSound()
        {
            soundManager = new SoundManager();
        }

        private void loadDatabase()
        {
            db = DatabaseManagerFactory.getDatabaseManager("txt");
        }

        private void initializeCounters()
        {
            timerCounter = CounterFactory.getCounter("Time");
            scoreCounter = CounterFactory.getCounter("Score");
            livesCounter = CounterFactory.getCounter("Lives");
        }

        public static void loseLife()
        {

        }

        public static void loseGame()
        {
            soundManager.playSound("lose");
            endGame();
        }

        public static void winGame()
        {
            soundManager.playSound("win");
            db.addScore(scoreCounter.getValue());
        }

        public static void endGame()
        {
            // Handle end of a game
        }

        private int getHighScore()
        {
            return highScore;
        }

        private void setHighScore(int highScore)
        {
            this.highScore = highScore;
        }

        private void gameMenu_Click(object sender, EventArgs e)
        {

        }

    }
}
