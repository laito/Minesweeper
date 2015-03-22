using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    abstract class Counter
    {
        private int value = 0;

        public void incrementValue()
        {
            value++;
            onUpdate();
        }

        public int getValue()
        {
            return value;
        }

        public void resetValue()
        {
            value = 0;
            onUpdate();
        }

        public void decrementValue()
        {
            value--;
            onUpdate();
        }

        public abstract void onUpdate();
    }
}
