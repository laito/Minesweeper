using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Grid
    {
        private Grid me = null;
        private static Cell[,] cells;
        private static int rows;
        private static int cols;

        public static Cell getCell(int x, int y)
        {
            return cells[x , y];
        }

        public Grid(int rows_p, int cols_p)
        {
            rows = rows_p;
            cols = cols_p;
            initializeCells();
            Game.getInstance().Height = rows * 50 + 100;
            Game.getInstance().Width = cols * 50 + 80; 
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
            int mines = GameSettings.getMines();

            cells = new Cell[cols, rows];

            var mineRange = new Random();
            var mineLocations = Enumerable.Range(0, col * rows).OrderBy(x => mineRange.Next()).ToArray();

            for (int counter = 0; counter < GameSettings.getMines(); counter++)
            {
                int location = mineLocations[counter];
                int x = location / col;
                int y = location % col;
                cells[x, y] = CellFactory.getCell("Mine", x, y);
            }

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    if (cells[x, y] == null)
                    {
                        // Generate a cell
                        Cell newCell = CellFactory.getCell("Normal", x, y);
                        cells[x, y] = newCell;
                    }
                }
            }
        }
    }
}
