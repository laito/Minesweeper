using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class DatabaseManagerFactory
    {
        private static DatabaseManager databaseManager = null;

        public static DatabaseManager getDatabaseManager(String dbManager)
        {
            return databaseManager;
        }
    }
}
