using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class MineCell : Cell
    {
        public MineCell(int x, int y): base(x, y)
        {

        }

        public override void processCell(Object sender, EventArgs e)
        {
            Button cell = base.getButton();
            cell.Text = "M";
            cell.Enabled = false;
            Console.WriteLine("Cicked on a mine");
            Game.loseLife();
        }
    }
}
