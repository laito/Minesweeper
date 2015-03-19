using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class MineCell : Cell
    {
        public MineCell(int x, int y): base(x, y)
        {

        }

        public override void processCell(Object sender, EventArgs e)
        {
            Console.WriteLine("Cicked on a mine");
            Game.loseLife();
        }
    }
}
