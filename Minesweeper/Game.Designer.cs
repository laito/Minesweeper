using System.Windows.Forms;
namespace Minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.playButton = new System.Windows.Forms.Button();
            this.livesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.smileyImg = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smileyImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(406, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameMenu
            // 
            this.gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerLevel,
            this.intermediateLevel,
            this.quitToolStripMenuItem});
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(60, 24);
            this.gameMenu.Text = "Game";
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(163, 24);
            this.beginnerLevel.Text = "Beginner";
            this.beginnerLevel.Click += new System.EventHandler(this.beginnerLevel_Click);
            // 
            // intermediateLevel
            // 
            this.intermediateLevel.Name = "intermediateLevel";
            this.intermediateLevel.Size = new System.Drawing.Size(163, 24);
            this.intermediateLevel.Text = "Intermediate";
            this.intermediateLevel.Click += new System.EventHandler(this.intermediateLevel_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 24);
            this.helpMenu.Text = "Help";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(159, 169);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Location = new System.Drawing.Point(12, 345);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(36, 17);
            this.livesLabel.TabIndex = 2;
            this.livesLabel.Text = "lives";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(172, 345);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(43, 17);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "score";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(348, 345);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 17);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "time";
            // 
            // smileyImg
            // 
            this.smileyImg.Location = new System.Drawing.Point(183, 31);
            this.smileyImg.Name = "smileyImg";
            this.smileyImg.Size = new System.Drawing.Size(32, 28);
            this.smileyImg.TabIndex = 5;
            this.smileyImg.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 371);
            this.Controls.Add(this.smileyImg);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Game";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smileyImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem beginnerLevel;
        private System.Windows.Forms.ToolStripMenuItem intermediateLevel;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private Button playButton;
        public Label livesLabel;
        public Label scoreLabel;
        public Label timeLabel;
        public PictureBox smileyImg;
    }
}

