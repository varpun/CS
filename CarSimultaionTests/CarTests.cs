using CarSimulation.Model;
using NUnit.Framework;

namespace CarSimultaionTests
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        public void Car_Initialization_SetsProperties()
        {
            // Arrange
            string name = "A";
            Position position = new Position(1, 2);
            Direction direction = Direction.N;
            string commands = "FFRFF";

            // Act
            Car car = new Car(name, position, direction, commands);

            // Assert
            Assert.AreEqual(name, car.Name);
            Assert.AreEqual(position, car.SimulatedPosition);
            Assert.AreEqual(direction, car.SimulatedDirection);
            Assert.AreEqual(commands, car.SimulatedCommands);
            Assert.IsFalse(car.IsCollision);
        }

        [Test]
        public void Car_ExecuteNextCommand_RotatesLeft()
        {
            // Arrange
            Car car = new Car("A", new Position(1, 2), Direction.N, "L");

            // Act
            car.ExecuteNextCommand();

            // Assert
            Assert.AreEqual(Direction.W, car.SimulatedDirection);
        }

        [Test]
        public void Car_ExecuteNextCommand_RotatesRight()
        {
            // Arrange
            Car car = new Car("A", new Position(1, 2), Direction.N, "R");

            // Act
            car.ExecuteNextCommand();

            // Assert
            Assert.AreEqual(Direction.E, car.SimulatedDirection);
        }

        [Test]
        public void Car_ExecuteNextCommand_MovesForward()
        {
            // Arrange
            Car car = new Car("A", new Position(1, 2), Direction.N, "F");

            // Act
            var newPosition = car.ExecuteNextCommand();

            // Assert
            Assert.AreEqual(new Position(1, 3), newPosition);
        }
    }
}