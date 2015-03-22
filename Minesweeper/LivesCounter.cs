using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class LivesCounter : Counter
    {
        private Label livesLabel = null;

        public LivesCounter()
        {
            livesLabel = (Label) Game.getUIElement("livesLabel");
            base.incrementValue();
        }

        public override void onUpdate()
        {        
            livesLabel.Text = base.getValue().ToString();
        }
    }
}
