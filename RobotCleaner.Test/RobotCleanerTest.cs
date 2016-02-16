using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotCleaner.Test
{
    [TestClass]
    public class RobotCleanerTest
    {
        [TestMethod]
        public void GetCleanedLocationsTest()
        {
            var startLocation = new Location(22, 10);
            var commands = new List<RobotCommand>
            {
                new RobotCommand(Direction.East, 2),
                new RobotCommand(Direction.North, 1)
            };
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommands(commands);

            const int expectedCleanedLocations = 4;
            Assert.AreEqual(expectedCleanedLocations, robot.GetCleanedLocations());
        }

        [TestMethod]
        public void CleanWestTest()
        {
            var startLocation = new Location(22, 10);
            var command = new RobotCommand(Direction.West, 23);
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommand(command);

            var expectedLastLocation = new Location(-1, 10);
            Assert.AreEqual(expectedLastLocation, robot.LastLocation);
        }

        [TestMethod]
        public void CleanEastTest()
        {
            var startLocation = new Location(22, 10);
            var command = new RobotCommand(Direction.East, 2);
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommand(command);

            var expectedLastLocation = new Location(24, 10);
            Assert.AreEqual(expectedLastLocation, robot.LastLocation);
        }

        [TestMethod]
        public void CleanSouthTest()
        {
            var startLocation = new Location(22, 10);
            var command = new RobotCommand(Direction.South, 4);
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommand(command);

            var expectedLastLocation = new Location(22, 6);
            Assert.AreEqual(expectedLastLocation, robot.LastLocation);
        }

        [TestMethod]
        public void CleanNorthTest()
        {
            var startLocation = new Location(22, 10);
            var command = new RobotCommand(Direction.North, 3);
            var robot = new RobotCleaner(startLocation);
            robot.ExecuteCommand(command);

            var expectedLastLocation = new Location(22,13);
            Assert.AreEqual(expectedLastLocation, robot.LastLocation);
        }
    }
}
