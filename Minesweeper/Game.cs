using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            initializeUI();
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
            initializeSound();
            initializeSettings();
            initializeCounters();
            initializeGrid();
        }

        private void initializeUI()
        {
            // Fonts
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("digital.ttf");
            livesLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            scoreLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            timeLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            // Smiley Image
            //Image smileyImage = Image.FromFile("smiley.gif");
            //smileyImg.Image = smileyImage;
            smileyImg.ImageLocation = @"smiley.jpg";

            //Set Intermediate to locked
            intermediateLevel.Enabled = false;
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
            timerCounter = CounterFactory.getCounter("Timer");
            scoreCounter = CounterFactory.getCounter("Score");
            livesCounter = CounterFactory.getCounter("Lives");
        }

        public static void loseLife()
        {
            livesCounter.decrementValue();
            if (livesCounter.getValue() == 0)
            {
                loseGame();
            }

        }

        public static void loseGame()
        {
            soundManager.playSound("lose");
            db.addScore(scoreCounter.getValue());
            db.closeDB();
            MessageBox.Show(reference, "Game Over.");
            System.Windows.Forms.Application.Exit();
        }

        public static void winGame()
        {
            soundManager.playSound("win");
            db.addScore(scoreCounter.getValue());
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

        
        private void playButton_Click(object sender, EventArgs e)
        {
            initializeGame();
            playButton.Visible = false;
        }

        public static Object getUIElement(String UIElement)
        {
            String[] UIElements = { "livesLabel", "scoreLabel", "timeLabel", "simleyImg", "playButton", "intermediateLevel" };
            if (UIElements.Contains(UIElement))
            {
                Game self = Game.getInstance();
                Console.WriteLine(UIElement);
                return self.GetType().GetField(UIElement).GetValue(self);
            }
            return null; // UI element not found
        }

        private void Game_Load(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
