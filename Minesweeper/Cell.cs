using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    abstract class Cell
    {
        private Boolean opened;
        private Button btn;
        private int x;
        private int y;
        

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            btn = new Button();
            btn.Location = new System.Drawing.Point(30 + 50*x, 30 + 50*y);
            btn.Size = new System.Drawing.Size(50, 50);
            btn.Click += new System.EventHandler(this.processCell);
            btn.TabStop = false;
            Game.getInstance().Controls.Add(btn);
        }

        public Button getButton()
        {
            return btn; 
        }

        public Boolean getOpened()
        {
            return opened;
        }

        public void setOpened(Boolean open)
        {
            this.opened = open; 
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
        public void setPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        abstract public void processCell(Object sender, EventArgs e);
    }
}
