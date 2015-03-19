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

        private static Grid grid;
        private static GameSettings settings;
        private static DatabaseManager db;
        private static SoundManager soundManager;

        private static Game reference = null;

        public Game()
        {
            InitializeComponent();
            reference = this;
        }

        public static Game getInstance()
        {
            return reference;
        }

        private void gameLoad(object sender, EventArgs e)
        {
            initializeGame();
        }

        private void initializeGame()
        {
            loadDatabase();
            initializeSound();
            initializeSettings();
            initializeCounters();
            initializeGrid();
        }

        private void initializeGrid()
        {
            grid = new Grid(GameSettings.getRows(), GameSettings.getColumns());
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

        /* Click Handlers */

        private void beginnerLevel_Click(object sender, EventArgs e)
        {
            GameSettings.setLevel(1);
        }

        private void intermediateLevel_Click(object sender, EventArgs e)
        {
            GameSettings.setLevel(2);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            initializeGame();
        }

        private void splitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        
        private void playButton_Click(object sender, EventArgs e)
        {
            initializeGame();
            playButton.Visible = false;
        }

    }
}
