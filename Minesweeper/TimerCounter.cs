using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class TimerCounter : Counter
    {
        private Timer myTimer;

        public TimerCounter()
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(timerTick);
            myTimer.Interval = 1000; // in milliseconds (default interval is 1 second)
            myTimer.Start();
        }

        private void timerTick(object Sender, EventArgs e)
        {
            base.incrementValue();
            int curTime = base.getValue();
            if (curTime == GameSettings.getTimeLimit())
            {
                Counter livesCounter = CounterFactory.getCounter("lives");
                if(livesCounter.getValue() > 1) {
                    livesCounter.decrementValue();
                    base.resetValue();
                } else 
                {
                }
            }
        }
    }
}