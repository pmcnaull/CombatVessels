using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class CombatVesselsGame
    {
        GameBoard _player1Board;
        GameBoard _player2Board;

        IPlayer _player1;
        IPlayer _player2;

        public CombatVesselsGame(IPlayer player1, IPlayer player2)
        {
            // Store references to each player
            _player1 = player1;
            _player2 = player2;
        }

        /// <summary>
        /// Let each player take a turn.
        /// If the first player wins on their turn, then the second player will not get to take their turn.
        /// </summary>
        public void TakeTurns()
        {
            // Variable to hold the next shot that will be taken
            Square nextShot;
            // Get the next shot that the next player intends to make
            nextShot = _player1.TakeTurn();
            // Tell the board and the other player that the shot is being mad
            
            // Check to see if the player that just took their shot is the winner

            // Let the second player play
            nextShot = _player2.TakeTurn();
            // Tell the board and the other player that the shot is being made

            // Check to see if the player that just took their shot is the winner

        }

        void LoadPlayers()
        {

        }

        List<Ship> InitShips()
        {
            List<Ship> ships = new List<Ship>();
            ships.Add(new Ship(5, "Carrier"));
            ships.Add(new Ship(4, "Battleship"));
            ships.Add(new Ship(3, "Submarine"));
            ships.Add(new Ship(3, "Cruiser"));
            ships.Add(new Ship(2, "Destroyer"));
            return ships;
        }

    }
}
