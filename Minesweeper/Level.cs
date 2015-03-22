using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class Level
    {
        public static int getColumns(int ID)
        {
            return ID * 5;
        }

        public static int getRows(int ID)
        {
            return ID * 5;
        }

        public static int getMines(int ID)
        {
            return ID * 5;
        }

        public static int getTimeLimit(int ID)
        {
            return 60;
        }

        public static void unlockLevels(int highScore)
        {
            if (highScore > 1)
            {
                ToolStripMenuItem intermediateLevel = (ToolStripMenuItem)Game.getUIElement("intermediateLevel");
                intermediateLevel.Enabled = true;
            }
        }
    }
}
