using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class MySQLManager : DatabaseManager
    {
        private String host;
        private int port;
        private String password;
        private String username;

        public override void initializeDB() {
            // Create a MySQL Connection
        }

        public override void closeDB()
        {
            
        }
        
        public override void addScore(int Score) {
        }

        public override List<int> getScores()
        {
            return null;
        }

        public override int getHighscore()
        {
            return 0;
        }
    }
}
