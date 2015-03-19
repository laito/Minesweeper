using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class GameSettings
    {        
        private static int levelID = 1; // Default level is beginner
        private static int rows;
        private static int columns;
        private static int timeLimit;
        private static int mines; 

        public GameSettings()
        {
            initialize();
        }

        public static void initialize()
        {
            rows = Level.getRows(levelID);
            columns = Level.getColumns(levelID);
            mines = Level.getMines(levelID);
        }

        public static void setLevel(int LevelID)
        {
            levelID = LevelID;
            initialize();
        }

        public static int getRows()
        {
            return rows;
        }

        public static int getColumns()
        {
            return columns;
        }

        public static int getMines()
        {
            return mines; 
        }

        public static int getTimeLimit()
        {
            return timeLimit;
        }

        public static void setRows(int numRows)
        {
            rows = numRows;
        }

        public static void setColumns(int numColumns)
        {
            columns = numColumns;
        }

        public static void setTimeLimit(int TimeLimit)
        {
            timeLimit = TimeLimit;
        }
    }
}
