using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            return 5;
        }
    }
}
