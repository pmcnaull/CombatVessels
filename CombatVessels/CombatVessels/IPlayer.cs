using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    public interface IPlayer
    {
        Square TakeTurn();
        void RecordShotResult(ShotResult result);

    }
}
