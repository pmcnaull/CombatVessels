using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class Board
    {
        int _length;
        int _width;
        ShotResult[,] _squares;

        /// <summary>
        /// Initializes a new board of a given length and width
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Board(int length, int width)
        {
            _length = length;
            _width = width;
            _squares = new ShotResult[_length, _width];
        }
    }
}
