using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class CellFactory
    {
        public static Cell getCell(String cellType)
        {
            Cell newCell = null;

            if (cellType.Equals("Mine"))
            {
                newCell = new MineCell();
            }
            else if (cellType.Equals("Normal"))
            {
                newCell = new NormalCell();
            }
            else if (cellType.Equals("PowerSource"))
            {
                newCell = new PowerSourceCell();
            }
            return newCell;
        }
    }
}
