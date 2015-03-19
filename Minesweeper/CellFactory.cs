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
            Console.WriteLine("TEst");
            Cell newCell = null;

            if (cellType.Equals("Mine"))
            {
                newCell = new MineCell(x, y);
            }
            else if (cellType.Equals("Normal"))
            {
                Console.WriteLine("TEst");
                newCell = new NormalCell(x, y);
                Console.WriteLine("TEst");
            }
            else if (cellType.Equals("PowerSource"))
            {
                newCell = new PowerSourceCell(x, y);
            }

            return newCell;
        }
    }
}
