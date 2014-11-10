using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatVessels.Events;

namespace CombatVessels
{
    class GameBoard: Board
    {
        /// <summary>
        /// List of all ships on the board
        /// </summary>
        List<Ship> _ships = new List<Ship>();

        /// <summary>
        /// Dictionary between a ship and the squares it occupies
        /// </summary>
        Dictionary<Ship, List<Square>> _shipSquares = new Dictionary<Ship,List<Square>>();

        /// <summary>
        /// Event is raised when a ship is hit
        /// </summary>
        event ShipHitEventHandler ShipHit;

        void OnShipHit(Ship ship, Square squareJustHit)
        {
            if (ShipHit != null)
            {
                ShipHit(this, new ShipHitEventArgs(ship, squareJustHit));
            }
        }

        /// <summary>
        /// Event is raised when a ship is missed
        /// </summary>
        event ShipMissEventHandler ShipMiss;

        void OnShipMiss(Square squareJustMissed)
        {
            if (ShipMiss != null)
            {
                ShipMiss(this, new ShipMissEventArgs(squareJustMissed));
            }
        }

        /// <summary>
        /// Event is raised when a ship is sunk
        /// </summary>
        event ShipSunkEventHandler ShipSunk;

        void OnShipSunk(Ship ship)
        {
            if (ShipSunk != null)
            {
                ShipSunk(this, new ShipSunkEventArgs(ship));
            }
        }



        public GameBoard(int height, int width)
            : base(height, width)
        {

        }

        /// <summary>
        /// Attempts to place a ship on the board
        /// </summary>
        /// <param name="ship">Ship to be placed</param>
        /// <returns>True if the ship is placed successfully</returns>
        ShipPlacementResult TryPlaceShip(Ship ship)
        {
            //make sure the base square of the ship is within the limits of the board and that the direction has been specified
            if (!SquareIsValid(ship.BaseSquare))
            {
                return ShipPlacementResult.OffBoard;
            }
            else if (ship.Direction == ShipDirection.Unknown)
            {
                return ShipPlacementResult.DirectionUnknown;
            }
            else
            {
                //check that all of the spaces needed by the ship are currently unoccupied and on the board
                //if so, return true, otherwise false
                Square currentSquare = ship.BaseSquare;
                int lengthCounter = 0;
                while (lengthCounter < ship.Length)
                {
                    if (!SquareIsValid(currentSquare))
                    {
                        return ShipPlacementResult.OffBoard;
                    }
                    else if (SquareIsOccupied(currentSquare))
                    {
                        return ShipPlacementResult.SquaresAlreadyOccupied;
                    }

                    //move to the next square to check
                    if (ship.Direction == ShipDirection.Horizontal)
                    {
                        currentSquare = new Square(currentSquare.Row, currentSquare.Column + 1);
                    }
                    else if (ship.Direction == ShipDirection.Vertical)
                    {
                        currentSquare = new Square(currentSquare.Row + 1, currentSquare.Column);
                    }
                    lengthCounter++;
                }

                //if the code makes it to here, all of the spaces requested by the ship are OK to use
                //TODO: place ship on board
                return ShipPlacementResult.OK;
            }
        }

        
        /// <summary>
        /// Returns true if the given square is occupied by a ship
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        bool SquareIsOccupied(Square square)
        {
            return SquareIsValid(square) && _shipSquares.Values.Any(s => s.Contains(square));
        }

        /// <summary>
        /// Takes a shot and returns whether it was a hit or miss given the current board
        /// </summary>
        /// <param name="shot">Shot object</param>
        /// <returns>True if the square is occupied by a ship</returns>
        ShotResult Shoot(Square shot)
        {
            bool isHit = SquareIsOccupied(shot);
            if (isHit)
            {
                //figure out which ship was just hit
                KeyValuePair<Ship, List<Square>> squaresForShip = _shipSquares.First(s => s.Value.Contains(shot));
                Ship ship = squaresForShip.Key;

                //tell anyone listening that the ship has been hit
                OnShipHit(ship, shot);
                
                //check to see if the ship was sunk, and if so, tell anyone listening that the ship was sunk
                if (ship.IsSunk)
                {
                    OnShipSunk(ship);
                }
            }
            else
            {
                //tell the listeners that the shot was a miss
                OnShipMiss(shot);
            }

            return isHit ? ShotResult.Hit : ShotResult.Miss;            
        }
    }
}
