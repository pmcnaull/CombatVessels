using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels.Events
{
    class ShipHitEventArgs
    {
        public Ship Ship;
        public Square SquareJustGuessed;

        public ShipHitEventArgs(Ship ship, Square squareJustGuessed)
        {
            Ship = ship;
            SquareJustGuessed = squareJustGuessed;
        }
    }

    delegate void ShipHitEventHandler(object sender, ShipHitEventArgs e);
}
