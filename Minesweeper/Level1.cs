using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Level1 : Level
    {
        public Level1()
        {
            base.setName("Beginner");
            base.setColumns(10);
            base.setRows(10);
        }
    }
}
