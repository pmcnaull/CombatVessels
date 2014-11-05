using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class Board
    {
        protected int _height;
        protected int _width;
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

        /// <summary>
        /// Returns true if the square is a valid selection within the board
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        protected bool SquareIsValid(Square square)
        {
            return square.Row < 0
                || square.Column < 0
                || square.Row > (_height - 1)
                || square.Column > (_width - 1);
        }
    }
}
