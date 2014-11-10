using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels.Events
{
    class ShipSunkEventArgs
    {
        public Ship Ship;

        public ShipSunkEventArgs(Ship ship)
        {
            Ship = ship;
        }
    }

    delegate void ShipSunkEventHandler(object sender, ShipSunkEventArgs e);
}
