using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfComands = Int32.Parse(Console.ReadLine());

            var startLocation = CommandParser.ParseRobotLocation(Console.ReadLine());
            var robotCommands = new List<RobotCommand>();
            for (int i = 0; i < numberOfComands; i++)
            {
                var command = CommandParser.ParseRobotCommand(Console.ReadLine());
                robotCommands.Add(command);
            }
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommands(robotCommands);
            Console.WriteLine("Cleaned: {0}", robot.GetCleanedLocations());
        }
    }
}
