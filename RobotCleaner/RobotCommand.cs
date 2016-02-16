using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner
{
    /// <summary>
    /// Class for representing a single instruction to robot cleaner
    /// </summary>
    public class RobotCommand
    {
        public int Distance { get; set; }
        public Direction Direction { get; set; }

        public RobotCommand()
        {

        }

        public RobotCommand(Direction direction, int distance)
        {
            Distance = distance;
            Direction = direction;
        }

        protected bool Equals(RobotCommand other)
        {
            return Distance == other.Distance && Direction == other.Direction;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Distance*397) ^ (int) Direction;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RobotCommand) obj);
        }
    }
}
