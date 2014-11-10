using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    public class Ship
    {
        int _length;

        public int Length
        {
            get { return _length; }
        }

        int _hitCounter;

        /// <summary>
        /// Returns true if the ship has been hit the number of its length
        /// </summary>
        internal bool IsSunk
        {
            get { return _hitCounter == _length; }
        }
            

        string _name;

        Square _baseSquare;

        /// <summary>
        /// The base square indicates the top left-most square of the ship
        /// </summary>
        public Square BaseSquare
        {
            get { return _baseSquare; }
            set { _baseSquare = value; }
        }

        ShipDirection _direction = ShipDirection.Unknown;

        public ShipDirection Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
            

        /// <summary>
        /// Constructs a new ship with a given length
        /// </summary>
        /// <param name="length">Length of the ship</param>
        /// <param name="name">Name of the ship</param>
        public Ship(int length, string name)
        {
            _length = length;
            _name = name;
        }

        /// <summary>
        /// Tells a ship that it has been hit
        /// </summary>
        internal void Hit()
        {
            _hitCounter++;
        }

        
    }
}
