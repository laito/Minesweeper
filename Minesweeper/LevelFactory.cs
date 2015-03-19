using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class LevelFactory
    {
        static Level level = null;

        internal Level Level
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static Level getLevel()
        {
            level = new Level1(); // Default level
            return level;
        }

        public static Level getLevel(String levelName)
        {
            if (levelName.Equals("Beginner"))
            {
                level = new Level1();
            }
            else if (levelName.Equals("Intermediate"))
            {
                level = new Level2();
            }
            return level;
        }
    }
}
