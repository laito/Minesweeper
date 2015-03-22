using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class PowerSourceCell : NormalCell
    {
        public PowerSourceCell(int x, int y): base(x, y)
        {
            Button myBtn = base.getButton();
            myBtn.TabStop = true;
            myBtn.TabIndex = 1;
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
