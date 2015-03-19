using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class MineCell : Cell
    {
        public override void processCell()
        {
            Game.loseLife();
            base.turnON();
        }
    }
}
