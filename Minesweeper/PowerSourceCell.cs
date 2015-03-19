using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class PowerSourceCell : NormalCell
    {
        public PowerSourceCell(int x, int y): base(x, y)
        {

        }
        public override void processCell(Object sender, EventArgs e)
        {
            Counter livesCounter = CounterFactory.getCounter("Lives");
            livesCounter.incrementValue();
            base.processCell(sender, e);
        }
    }
}
