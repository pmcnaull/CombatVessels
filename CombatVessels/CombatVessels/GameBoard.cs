using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class GameBoard: Board
    {
        /// <summary>
        /// List of all ships on the board
        /// </summary>
        List<Ship> _ships = new List<Ship>();

        /// <summary>
        /// Indicates the status of which spaces are occupied by a ship
        /// </summary>
        bool[,] _squareOccupiedStatus;


        public GameBoard(int height, int width)
            : base(height, width)
        {

            _squareOccupiedStatus = new bool[height, width];
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
        /// <param name="shot">Shot object</param>
        /// <returns>True if the square is occupied by a ship</returns>
        ShotResult Shoot(Square shot)
        {
            return _squareOccupiedStatus[shot.Row, shot.Column] ? ShotResult.Hit : ShotResult.Miss;            
        }
    }
}
