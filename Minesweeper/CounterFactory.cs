using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class CounterFactory
    {

        private static Counter timerCounter = null;
        private static Counter livesCounter = null;
        private static Counter scoreCounter = null;

        internal Counter Counter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static Counter getCounter(String counter)
        {
            if (counter == "Timer")
            {
                if (timerCounter == null)
                {
                    timerCounter = new TimerCounter();
                }
                return timerCounter;
            } else if (counter.Equals("Lives")) 
            {
                if (livesCounter == null)
                {
                    livesCounter = new LivesCounter();
                }
                return livesCounter;
            } else if (counter.Equals("Score")) 
            {
                if (scoreCounter == null)
                {
                    scoreCounter = new ScoreCounter();
                }
                return scoreCounter;
            }
            return null;
        }
    }
}
