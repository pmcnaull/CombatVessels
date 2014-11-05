using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    /// <summary>
    /// Interface for a player of the CombatVessels game.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Take a turn by guessing a square to shoot at.
        /// </summary>
        /// <returns>Square of this player's guess</returns>
        Square TakeTurn();
        /// <summary>
        /// Record the result of a shot that was just taken.  This method should be called after a call to TakeTurn()
        /// </summary>
        /// <param name="shotLocation">Location of the shot that the provided ShotResult refers to</param>
        /// <param name="result">ShotResult representing whether the most recent shot was a hit or miss</param>
        void RecordShotResult(Square shotLocation, ShotResult result);

    }
}
