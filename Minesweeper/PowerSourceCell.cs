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
            Console.WriteLine("Clicked the power source cell.");
            Counter livesCounter = CounterFactory.getCounter("Lives");
            livesCounter.incrementValue();
            base.processCell(sender, e);
        }

        public void processPowerCell(Object sender, EventArgs e)
        {
            Console.WriteLine("Did not increment lives.");
            base.processCell(sender, e);
        }
    }
}
