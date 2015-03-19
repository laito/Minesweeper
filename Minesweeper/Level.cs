using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Level
    {
        private String name;
        private int rows;
        private int columns;
        private Boolean locked;

        internal GameSettings GameSettings
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void setLock() {
            locked = true;
        }

        public void unLock()
        {
            locked = false;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName() {
            return name;
        }

        public int getColumns()
        {
            return columns;
        }

        public void setColumns(int columns)
        {
            this.columns = columns;
        }

        public int getRows()
        {
            return rows;
        }

        public void setRows(int rows)
        {
            this.rows = rows;
        }
    }
}
