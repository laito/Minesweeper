using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class ScoreCounter : Counter
    {
        private Label scoreLabel = null;

        public ScoreCounter()
        {
            scoreLabel = (Label) Game.getUIElement("scoreLabel");
            base.resetValue();
        }

        public override void onUpdate()
        {        
            scoreLabel.Text = base.getValue().ToString();
        }
    }
}
