using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class Counter
    {
        private int value = 0;

        public Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void incrementValue()
        {
            value++;
        }

        public int getValue()
        {
            return value;
        }

        public void resetValue()
        {
            value = 0;
        }

        public void decrementValue()
        {
            value--;
        }
    }
}
