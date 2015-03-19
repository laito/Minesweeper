using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Grid
    {
        private Grid me = null;
        private static Cell[] cells;
        private static int rows;
        private static int cols;

        public static Cell getCell(int x, int y)
        {
            return cells[x * cols + y];
        }

        private Grid(int rows_p, int cols_p)
        {
            rows = rows_p;
            cols = cols_p;
            initializeCells();
        }

        public Grid getGrid(int rows, int cols) {
            if (me == null)
            {
                me = new Grid(rows, cols);
            }
            return me;
        }

        public void initializeCells()
        {
            int col = GameSettings.getColumns();
            int rows = GameSettings.getRows();
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    // Generate a cell
                    
                }
            }
        }
    }
}
