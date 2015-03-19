using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Smiley
    {
        private String smileyImagePath = "";
        private String loaseImagePath = "";
        private String winImagePath = "";

        public Smiley()
        {

        }

        private static Boolean state;

        public void setState(Boolean hasWon)
        {
            if (hasWon)
            {

            }
            else
            {

            }
        }

        public Boolean getState()
        {
            return state;
        }
    }
}
