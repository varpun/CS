using CarSimulation;
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
    public class SimulationServiceTests
    {
        private Field CreateField(int width, int height)
        {
            return new Field(width, height);
        }

        private Car CreateCar(string name, Position position, Direction direction, string commands)
        {
            return new Car(name, position, direction, commands);
        }

        [Test]
        public void AddCar_ValidCar_CarAddedToList()
        {
            // Arrange
            Field field = CreateField(10, 10);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car = CreateCar("Car1", new Position(0, 0), Direction.N, "F");

            // Act
            simulationService.AddCar(car);

            // Assert
            Assert.AreEqual(1, simulationService.Cars.Count);
            Assert.AreEqual(car, simulationService.Cars[0]);
        }

        [Test]
        public void RunSimulation_SingleCarMovesWithinBounds_NoCollisions()
        {
            // Arrange
            Field field = CreateField(10, 10);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car = CreateCar("Car1", new Position(0, 0), Direction.N, "FF");

            simulationService.AddCar(car);

            // Act
            simulationService.RunSimulation();

            // Assert
            Assert.AreEqual(new Position(0, 2), car.SimulatedPosition);
            Assert.IsFalse(car.IsCollision);
            Assert.AreEqual(0, simulationService.CarCollisionList[0].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[1].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[2].Count);
        }

        [Test]
        public void RunSimulation_SingleCarMovesOutOfBounds_NoCollisionDetected()
        {
            // Arrange
            Field field = CreateField(10, 10);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car = CreateCar("Car1", new Position(7, 7), Direction.N, "FFFFFF");

            simulationService.AddCar(car);

            // Act
            simulationService.RunSimulation();

            // Assert
            Assert.AreEqual(new Position(7, 9), car.SimulatedPosition);
            Assert.False(car.IsCollision);
            Assert.AreEqual(0, simulationService.CarCollisionList[0].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[1].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[2].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[3].Count);
        }

        [Test]
        public void RunSimulation_MultipleCarsCollide_CollisionDetectedForAllCars()
        {
            // Arrange
            Field field = CreateField(10, 10);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car1 = CreateCar("Car1", new Position(0, 0), Direction.N, "FF");
            Car car2 = CreateCar("Car2", new Position(0, 1), Direction.N, "F");
            Car car3 = CreateCar("Car3", new Position(0, 2), Direction.N, "R");

            simulationService.AddCar(car1);
            simulationService.AddCar(car2);
            simulationService.AddCar(car3);

            // Act
            simulationService.RunSimulation();

            // Assert
            Assert.IsTrue(car1.IsCollision);
            Assert.IsTrue(car2.IsCollision);
            Assert.False(car3.IsCollision); 
            Assert.AreEqual(2, simulationService.CarCollisionList[1].Count);
            Assert.Contains(car1, simulationService.CarCollisionList[1]);
            Assert.Contains(car2, simulationService.CarCollisionList[1]);
            Assert.AreEqual(car1.SimulatedPosition, car2.SimulatedPosition);
        }

        [Test]
        public void RunSimulation_MultipleCarsNoCollide_NoCollisionDetectedForAllCars()
        {
            Field field = CreateField(10, 10);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car1 = CreateCar("Car1", new Position(2, 2), Direction.N, "FFF");
            Car car2 = CreateCar("Car2", new Position(3, 3), Direction.E, "FFF");

            simulationService.AddCar(car1);
            simulationService.AddCar(car2);

            // Act
            simulationService.RunSimulation();

            // Assert
            Assert.False(car1.IsCollision);
            Assert.False(car2.IsCollision);
            Assert.AreEqual(0, simulationService.CarCollisionList[0].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[1].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[2].Count);
        }

        [Test]
        public void RunSimulation_SingleCarMovesOutOfBoundsAndMovesBack_NoCollisionDetected()
        {
            // Arrange
            Field field = CreateField(5, 5);
            List<Car> cars = new List<Car>();
            Dictionary<int, List<Car>> carCollisionList = new Dictionary<int, List<Car>>();
            SimulationService simulationService = new SimulationService(field, cars, carCollisionList);
            Car car = CreateCar("Car1", new Position(3, 3), Direction.E, "FFFFRRFF");

            simulationService.AddCar(car);

            // Act
            simulationService.RunSimulation();

            // Assert
            Assert.AreEqual(new Position(2,3), car.SimulatedPosition);
            Assert.False(car.IsCollision);
            Assert.AreEqual(0, simulationService.CarCollisionList[0].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[1].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[2].Count);
            Assert.AreEqual(0, simulationService.CarCollisionList[3].Count);
        }

    }
}
