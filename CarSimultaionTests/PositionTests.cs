using CarSimulation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimultaionTests
{
    [TestFixture]
    public class PositionTests
    {
        [Test]
        public void Equals_TwoEqualPositions_ReturnsTrue()
        {
            // Arrange
            Position position1 = new Position(2, 3);
            Position position2 = new Position(2, 3);

            // Act
            bool result = position1.Equals(position2);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Equals_TwoDifferentPositions_ReturnsFalse()
        {
            // Arrange
            Position position1 = new Position(2, 3);
            Position position2 = new Position(4, 5);

            // Act
            bool result = position1.Equals(position2);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Equals_NullPosition_ReturnsFalse()
        {
            // Arrange
            Position position = new Position(2, 3);
            Position? nullPosition = null;

            // Act
            bool result = position.Equals(nullPosition);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void GetHashCode_TwoEqualPositions_HaveSameHashCode()
        {
            // Arrange
            Position position1 = new Position(2, 3);
            Position position2 = new Position(2, 3);

            // Act
            int hashCode1 = position1.GetHashCode();
            int hashCode2 = position2.GetHashCode();

            // Assert
            Assert.AreEqual(hashCode1, hashCode2);
        }

        [Test]
        public void GetHashCode_TwoDifferentPositions_HaveDifferentHashCodes()
        {
            // Arrange
            Position position1 = new Position(2, 3);
            Position position2 = new Position(4, 5);

            // Act
            int hashCode1 = position1.GetHashCode();
            int hashCode2 = position2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hashCode1, hashCode2);
        }
    }
}
