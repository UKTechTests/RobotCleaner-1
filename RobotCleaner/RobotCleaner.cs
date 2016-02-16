using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner
{
    /// <summary>
    /// A robot cleaner prototype.
    /// </summary>
    public class RobotCleaner
    {
        public Location LastLocation { get; set; }
        private readonly HashSet<Location> _cleanedLocations;

        /// <summary>
        /// Constructor. Initializes robot cleaner.
        /// </summary>
        /// <param name="startLocation">Robot start location</param>
        public RobotCleaner(Location startLocation)
        {
            LastLocation = startLocation;
            _cleanedLocations = new HashSet<Location> {startLocation};
        }

        /// <summary>
        /// Cleans single location and records last robot position.
        /// </summary>
        /// <param name="location">Location for cleaning</param>
        private void CleanLocation(Location location)
        {
            _cleanedLocations.Add(location);
            LastLocation = location;
        }

        /// <summary>
        /// Executes single robot command.
        /// </summary>
        /// <param name="command">Robot command for execution</param>
        public void ExecuteCommand(RobotCommand command)
        {
            var startLocation = new Location(LastLocation.X, LastLocation.Y);
            for (int steps = 1; steps <= command.Distance; steps++)
            {
                switch (command.Direction)
                {
                    case Direction.West:
                        CleanLocation(new Location(startLocation.X - steps, startLocation.Y));
                        break;
                    case Direction.East:
                        CleanLocation(new Location(startLocation.X + steps, startLocation.Y));
                        break;
                    case Direction.North:
                        CleanLocation(new Location(startLocation.X, startLocation.Y + steps));
                        break;
                    case Direction.South:
                        CleanLocation(new Location(startLocation.X, startLocation.Y - steps));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Execute multiple robot commands.
        /// </summary>
        /// <param name="commands">Robot commands</param>
        public void ExecuteCommands(List<RobotCommand> commands)
        {
            foreach (var command in commands)
            {
                ExecuteCommand(command);
            }
        }

        /// <summary>
        /// Calculates cleaned locations.
        /// </summary>
        /// <returns>Robot cleaned locations</returns>
        public int GetCleanedLocations()
        {
            return _cleanedLocations.Count;
        }
    }
}
