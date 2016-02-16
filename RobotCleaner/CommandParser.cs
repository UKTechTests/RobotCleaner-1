using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner
{
    /// <summary>
    /// Class for parsing robot commands input
    /// </summary>
    public static class CommandParser
    {
        /// <summary>
        /// Parses robot location. First expected parameters is point on horizontal axis of Cartesian coordinate system,
        /// and second expected parameter is point on vertical axis of Cartesian coordinate system.
        /// Points should be divided by single space.
        /// </summary>
        /// <param name="position">Robot location in sting format</param>
        /// <returns>Parsed robot location</returns>
        public static Location ParseRobotLocation(string position)
        {
            var splitted = position.Split(' ');
            var location = new Location(Int32.Parse(splitted[0]), Int32.Parse(splitted[1]));
            return location;
        }

        /// <summary>
        /// Parses robot command. First expected parameter is first capital letter of cardinal direction, and second
        /// is a distance which robot should move. Points should be divided by single space.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static RobotCommand ParseRobotCommand(string command)
        {
            var splitted = command.Split(' ');

            var robotCommand = new RobotCommand();
            robotCommand.Distance = Int32.Parse(splitted[1]);

            var direction = splitted[0];
            switch (direction)
            {
                case "W":
                    robotCommand.Direction = Direction.West;
                    break;
                case "E":
                    robotCommand.Direction = Direction.East;
                    break;
                case "N":
                    robotCommand.Direction = Direction.North;
                    break;
                case "S":
                    robotCommand.Direction = Direction.South;
                    break;
            }

            return robotCommand;
        }
    }
}
