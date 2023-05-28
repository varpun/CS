//using Moq;
//using NUnit.Framework;


namespace CarSimulation
{
    //[TestFixture]
    //public class SimulationTest
    //{
    //    private Mock<Field> fieldMock;
    //    private Mock<List<Car>> carsMock;
    //    private Mock<Dictionary<int, List<Car>>> carCollisionListMock;
    //    private SimulationService simulationService;
    //    [Test]
    //    public void AddCar_AddsCarToList()
    //    {
    //        // Arrange
    //        var fieldMock = new Mock<Field>();
    //        var carCollisionListMock = new Mock<Dictionary<int, List<Car>>>();

    //        var carMock = new Mock<Car>();

    //        var carList = new List<Car>();

    //        var service = new SimulationService(
    //            fieldMock.Object,
    //            carList,
    //            carCollisionListMock.Object
    //        );

    //        // Act
    //        service.AddCar(carMock.Object);

    //        // Assert
    //        Assert.Contains(carMock.Object, service.Cars);
    //    }

    //    [Test]
    //    public void RunSimulation_UpdatesCarPositions()
    //    {
    //        // Arrange
    //        var fieldMock = new Mock<Field>();
    //        var carCollisionListMock = new Mock<Dictionary<int, List<Car>>>();

    //        var car1Mock = new Mock<Car>();
    //        var car2Mock = new Mock<Car>();

    //        var carList = new List<Car> { car1Mock.Object, car2Mock.Object };

    //        var service = new SimulationService(
    //            fieldMock.Object,
    //            carList,
    //            carCollisionListMock.Object
    //        );

    //        // Act
    //        service.RunSimulation();

    //        // Assert
    //        car1Mock.Verify(c => c.ExecuteNextCommand(), Times.AtLeastOnce);
    //        car2Mock.Verify(c => c.ExecuteNextCommand(), Times.AtLeastOnce);
    //        // Add assertions for the expected behavior of car positions after the simulation
    //    }

    //    [Test]
    //    public void IsWithinBounds_ReturnsTrueForValidPosition()
    //    {
    //        // Arrange
    //        var fieldMock = new Mock<Field>();
    //        fieldMock.Setup(f => f.Width).Returns(10);
    //        fieldMock.Setup(f => f.Height).Returns(10);

    //        var carCollisionListMock = new Mock<Dictionary<int, List<Car>>>();

    //        var position = new Position(5, 5);
    //        var service = new SimulationService(
    //            fieldMock.Object,
    //            new List<Car>(),
    //            carCollisionListMock.Object
    //        );

    //        // Act
    //        bool result = service.IsWithinBounds(position);

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [Test]
    //    public void IsWithinBounds_ReturnsFalseForInvalidPosition()
    //    {
    //        // Arrange
    //        var fieldMock = new Mock<Field>();
    //        fieldMock.Setup(f => f.Width).Returns(10);
    //        fieldMock.Setup(f => f.Height).Returns(10);

    //        var carCollisionListMock = new Mock<Dictionary<int, List<Car>>>();

    //        var position = new Position(15, 5);
    //        var service = new SimulationService(
    //            fieldMock.Object,
    //            new List<Car>(),
    //            carCollisionListMock.Object
    //        );

    //        // Act
    //        bool result = service.IsWithinBounds(position);

    //        // Assert
    //        Assert.IsFalse(result);
    //    }

    //    [Test]
    //    public void IsCollision_NoCollision_ReturnsFalse()
    //    {

    //        // Arrange
    //        Car car1 = new Car("Car1", new Position(1, 1), Direction.N, "");
    //        Car car2 = new Car("Car2", new Position(2, 2), Direction.S, "");
    //        int step = 1;

    //        carsMock.Object.Add(car1);
    //        carsMock.Object.Add(car2);

    //        // Act
    //        bool result = simulationService.IsCollision(car1, step);

    //        // Assert
    //        Assert.IsFalse(result);
    //        Assert.IsFalse(car1.IsCollision);
    //        Assert.IsFalse(car2.IsCollision);
    //    }
        //[Test]
        //public void Simulation_AddCar_AddsCarToList()
        //{
        //    // Arrange
        //    SimulationService simulation = new SimulationService(new Field(9,9));
        //    Car car = new Car("A", new Position(1, 2), Direction.N, "FFRFF");

        //    // Act
        //    simulation.AddCar(car);

        //    // Assert
        //    Assert.Contains(car, simulation.Cars);
        //}

        //[Test]
        //public void Simulation_RunSimulation_ExecutesCommandsForAllCars()
        //{
        //    // Arrange
        //    SimulationService simulation = new SimulationService(new Field(9, 9));
        //    Car car1 = new Car("A", new Position(1, 2), Direction.N, "F");
        //    Car car2 = new Car("B", new Position(3, 4), Direction.S, "RFF");
        //    simulation.AddCar(car1);
        //    simulation.AddCar(car2);

        //    // Act
        //    simulation.RunSimulation();

        //    // Assert
        //    Assert.AreEqual(new Position(1, 3), car1.OriginalPosition);
        //    Assert.AreEqual(new Position(2, 4), car2.OriginalPosition);
        //}

        //[Test]
        //public void Simulation_RunSimulation_StopsCarsAtCollisionPoint()
        //{
        //    // Arrange
        //    SimulationService simulation = new SimulationService(new Field(9, 9));
        //    Car car1 = new Car("A", new Position(1, 2), Direction.N, "FFFF");
        //    Car car2 = new Car("B", new Position(2, 3), Direction.W, "RFF");
        //    simulation.AddCar(car1);
        //    simulation.AddCar(car2);

        //    // Act
        //    simulation.RunSimulation();

        //    // Assert
        //    Assert.IsTrue(car1.IsCollision);
        //    Assert.IsTrue(car2.IsCollision);
        //    Assert.AreEqual(new Position(1, 3), car1.OriginalPosition);
        //    Assert.AreEqual(new Position(1, 3), car2.OriginalPosition);
        //}
    //}
}
