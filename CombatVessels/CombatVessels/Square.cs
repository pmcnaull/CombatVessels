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


        #region Equality Testing
        public override bool Equals(object obj)
        {
            return obj is Square && this == (Square)obj;
        }

        public override int GetHashCode()
        {
            return _row.GetHashCode() ^ _column.GetHashCode();
        }

        public static bool operator ==(Square x, Square y)
        {
            return x._row == y._row && x._column == y._column;
        }

        public static bool operator !=(Square x, Square y)
        {
            return !(x == y);
        } 
        #endregion
    }
}
