using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    public struct Square
    {
        int _row;

        public int Row
        {
            get { return _row; }
        }

        int _column;

        public int Column
        {
            get {return _column; }
        }

        public Square(int row, int column)
        {
            _row = row;
            _column = column;
        }
    }
}
