using CarSimulation.Helper;
using CarSimulation.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimultaionTests
{
    [TestFixture]
    public class CommandParserTests
    {
        private CommandParser _commandParser;

        [SetUp]
        public void Setup()
        {
            _commandParser = new CommandParser();
        }

        [Test]
        public void TryParseFieldDimensions_ValidInput_ReturnsTrueAndSetsWidthAndHeight()
        {
            // Arrange
            string input = "5 5";
            int width, height;

            // Act
            bool result = _commandParser.TryParseFieldDimensions(input, out width, out height);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(5, width);
            Assert.AreEqual(5, height);
        }

        [Test]
        public void TryParseFieldDimensions_InvalidInput_ReturnsFalseAndSetsZeroWidthAndHeight()
        {
            // Arrange
            string input = "5A 5B";
            int width, height;

            // Act
            bool result = _commandParser.TryParseFieldDimensions(input, out width, out height);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, width);
            Assert.AreEqual(0, height);
        }

        [Test]
        public void TryParseCarDetails_ValidInput_ReturnsTrueAndSetsPositionAndDirection()
        {
            // Arrange
            string input = "1 2 N";
            Position position;
            Direction direction;

            // Act
            bool result = _commandParser.TryParseCarDetails(input, out position, out direction);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(new Position(1, 2), position);
            Assert.AreEqual(Direction.N, direction);
        }

        [Test]
        public void TryParseCarDetails_InvalidInput_ReturnsFalseAndSetsNullPositionAndDefaultDirection()
        {
            // Arrange
            string input = "1 A N";
            Position position;
            Direction direction;

            // Act
            bool result = _commandParser.TryParseCarDetails(input, out position, out direction);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(position);
            Assert.AreEqual(Direction.N, direction);
        }

        [Test]
        public void ValidateCommands_ValidInput_ReturnsTrue()
        {
            // Arrange
            string input = "LRF";

            // Act
            bool result = _commandParser.ValidateCommands(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateCommands_InvalidInput_ReturnsFalse()
        {
            // Arrange
            string input = "LRF123";

            // Act
            bool result = _commandParser.ValidateCommands(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateCommands_EmptyInput_ReturnsFalse()
        {
            // Arrange
            string input = "";

            // Act
            bool result = _commandParser.ValidateCommands(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateCommands_NullInput_ReturnsFalse()
        {
            // Arrange
            string input = null;

            // Act
            bool result = _commandParser.ValidateCommands(input);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
