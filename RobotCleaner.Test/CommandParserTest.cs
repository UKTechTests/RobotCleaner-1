using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotCleaner.Test
{
    [TestClass]
    public class CommandParserTest
    {
        [TestMethod]
        public void ParseLocationTest()
        {
            const string input = "22 10";
            var location = CommandParser.ParseRobotLocation(input);

            var expectedLocation = new Location(22, 10);
            Assert.AreEqual(expectedLocation, location);
        }

        [TestMethod]
        public void ParseWestCommandTest()
        {
            const string input = "W 5";
            var command = CommandParser.ParseRobotCommand(input);

            var expectedCommand = new RobotCommand(Direction.West, 5);
            Assert.AreEqual(expectedCommand, command);
        }

        [TestMethod]
        public void ParseEastCommandTest()
        {
            const string input = "E 5";
            var command = CommandParser.ParseRobotCommand(input);

            var expectedCommand = new RobotCommand(Direction.East, 5);
            Assert.AreEqual(expectedCommand, command);
        }

        [TestMethod]
        public void ParseNorthCommandTest()
        {
            const string input = "N 5";
            var command = CommandParser.ParseRobotCommand(input);

            var expectedCommand = new RobotCommand(Direction.North, 5);
            Assert.AreEqual(expectedCommand, command);
        }

        [TestMethod]
        public void ParseSouthCommandTest()
        {
            const string input = "S 5";
            var command = CommandParser.ParseRobotCommand(input);

            var expectedCommand = new RobotCommand(Direction.South, 5);
            Assert.AreEqual(expectedCommand, command);
        }
    }
}
