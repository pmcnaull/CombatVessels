using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatVessels
{
    class Ship
    {
        int _length;

        public int Length
        {
            get { return _length; }
        }

        string _name;
        bool [] _segments;
        Square _baseSquare;

        public Square BaseSquare
        {
            get { return _baseSquare; }
        }

        ShipDirection _direction = ShipDirection.Unknown;

        public ShipDirection Direction
        {
            get { return _direction; }
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
            _segments = new bool[_length];
        }

        public void HitAtIndex(int index)
        {

        }

    }
}
