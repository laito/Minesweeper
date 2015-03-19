using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class Cell
    {
        private Boolean opened;
        private int x;
        private int y;

        internal Grid Grid
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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

        public void turnON()
        {
            this.opened = false;
            processCell();
        }

        abstract public void processCell();
    }
}
