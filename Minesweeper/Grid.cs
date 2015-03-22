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

        public int countMines(int x, int y)
        {
            int count = 0;
            for (int ix = -1; ix < 2; ix++)
            {
                for (int iy = -1; iy < 2; iy++)
                {
                    // Calculate neighbour position
                    int neighbourX = x + ix;
                    int neighbourY = y + iy;
                    // If neighbour is within bounds of the grid
                    if (neighbourX >= 0 && neighbourX < rows && neighbourY >= 0 && neighbourY < cols)
                    {
                        if(cells[neighbourX, neighbourY] is MineCell)
                            count++;
                    }
                }
            }
            return count; 
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

            // Setting the location of the power cell 
            int powerLocation = mineLocations[GameSettings.getMines() + 1];
            int px = powerLocation / col;
            int py = powerLocation % col;

            PowerSourceCell powerCell = (PowerSourceCell)CellFactory.getCell("PowerSource", px, py);
            powerCell.setNeighbours(countMines(px, py));
            cells[px, py] = powerCell; 

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    if (cells[x, y] == null)
                    {
                        // Generate a cell
                        NormalCell newCell = (NormalCell)CellFactory.getCell("Normal", x, y);
                        int neighbours = countMines(x,y) ;
                        newCell.setNeighbours(neighbours);
                        cells[x, y] = newCell;
                    }
                }
            }
        }
    }
}
