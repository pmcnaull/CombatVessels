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

        public CombatVesselsGame()
        {

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
