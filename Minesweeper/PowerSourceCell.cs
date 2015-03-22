using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class PowerSourceCell : NormalCell
    {
        public PowerSourceCell(int x, int y): base(x, y)
        {

        }
        public override void processCell(Object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Counter livesCounter = CounterFactory.getCounter("Lives");
                livesCounter.incrementValue();
            }
            Console.WriteLine("Clicked the power source cell.");
         
            base.processCell(sender, e);
        }

    }
}
