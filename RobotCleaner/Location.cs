using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner
{
    /// <summary>
    /// Class for representing single location using Cartesian coordinate system.
    /// </summary>
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Constructor. Creates a single point in coordinate system.
        /// </summary>
        /// <param name="x">Point on horizontal axis</param>
        /// <param name="y">Point on vertical axis</param>
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected bool Equals(Location other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X*397) ^ Y;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Location) obj);
        }

        public override string ToString()
        {
            return String.Format("Location X: {0}, Y: {1}", X, Y);
        }
    }
}
