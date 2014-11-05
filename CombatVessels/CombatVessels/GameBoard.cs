using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class GameBoard: Board
    {

        public GameBoard(int length, int width)
            : base(length, width)
        {

        }

        /// <summary>
        /// Attempts to place a ship on the board
        /// </summary>
        /// <param name="ship">Ship to be placed</param>
        /// <returns>True if the ship is placed successfully</returns>
        bool TryPlaceShip(Ship ship)
        {

            return false;
        }

        /// <summary>
        /// Takes a shot and returns whether it was a hit or miss given the current board
        /// </summary>
        /// <param name="shot"></param>
        /// <returns></returns>
        ShotResult Shoot(Shot shot)
        {


            return ShotResult.None;
        }
    }
}
