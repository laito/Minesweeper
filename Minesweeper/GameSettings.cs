using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class GameSettings
    {
        private static Level level;
        private static String levelName = "Beginner"; //Default level
        private static int rows;
        private static int columns;
        private static int timeLimit;

        public GameSettings()
        {
            initialize();
        }

        public Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void initialize()
        {
            
            rows = level.getRows();
            columns = level.getColumns();
        }

        public void setLevel(String LevelName)
        {
            levelName = LevelName;
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
