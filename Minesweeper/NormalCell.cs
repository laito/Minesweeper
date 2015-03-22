﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    class NormalCell : Cell
    {

        public NormalCell(int x, int y) : base(x, y)
        {
        }

        private int neighbouringMines = 0;

        public void setNeighbours(int neighbours)
        {
            neighbouringMines = neighbours;
        }


        public override void processCell(Object sender, EventArgs e)
        {
            if (base.getOpened())
                return;
            base.setOpened(true); 
            
            Button cell = sender as Button; 
            cell.Enabled = false; 
            
            if (this.neighbouringMines == 0)
            {
                // Open neighbouring mine cells
                int x = base.getX();
                int y = base.getY();
                int rows = GameSettings.getRows();
                int columns = GameSettings.getColumns();
                for (int ix = -1; ix < 2; ix++)
                {
                    for (int iy = -1; iy < 2; iy++)
                    {
                        // Calculate neighbour position
                        int neighbourX = x + ix;
                        int neighbourY = y + iy;
                        // If neighbour is within bounds of the grid
                        if (neighbourX >= 0 && neighbourX < rows && neighbourY >= 0 && neighbourY < columns)
                        {
                            Cell neighbouringCell = Grid.getCell(neighbourX, neighbourY);
                            Console.WriteLine(neighbourX + "  " + neighbourY);
                            if (neighbouringCell is PowerSourceCell)
                            {
                                PowerSourceCell powerCell = (PowerSourceCell)neighbouringCell;
                                Console.WriteLine("Power source.");
                                powerCell.processPowerCell(neighbouringCell.getButton(), e);
                            }
                            else
                                neighbouringCell.processCell(neighbouringCell.getButton(), e);
                        }
                    }
                }
            }
            else
            {  
                cell.Text = neighbouringMines.ToString();
            }
        }
    }
}
