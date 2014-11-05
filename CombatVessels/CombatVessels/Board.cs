using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class Board
    {
        int _height;
        int _width;
        ShotResult[,] _squares;

        /// <summary>
        /// Initializes a new board of a given height and width
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public Board(int height, int width)
        {
            _height = height;
            _width = width;
            _squares = new ShotResult[_height, _width];
        }
    }
}
