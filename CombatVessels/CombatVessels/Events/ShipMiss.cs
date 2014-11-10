using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels.Events
{
    class ShipMissEventArgs
    {
        public Square SquareJustGuessed;

        public ShipMissEventArgs(Square squareJustGuessed)
        {
            SquareJustGuessed = squareJustGuessed;
        }
    }

    delegate void ShipMissEventHandler(object sender, ShipMissEventArgs e);
}
