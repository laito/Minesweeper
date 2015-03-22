using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class CellFactory
    {
        public static Cell getCell(String cellType, int x, int y)
        {
            Cell newCell = null;

            if (cellType.Equals("Mine"))
            {
                newCell = new MineCell(x, y);
            }
            else if (cellType.Equals("Normal"))
            {
                newCell = new NormalCell(x, y);
            }
            else if (cellType.Equals("PowerSource"))
            {
                newCell = new PowerSourceCell(x, y);
            }

            return newCell;
        }
    }
}
