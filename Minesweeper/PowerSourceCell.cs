using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class PowerSourceCell : NormalCell
    {
        public override void processCell()
        {
            Counter livesCounter = CounterFactory.getCounter("Lives");
            livesCounter.incrementValue();
            base.processCell();
        }
    }
}
