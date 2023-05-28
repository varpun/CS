using CarSimulation;
using CarSimulation.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimultaionTests
{
    [TestFixture]
    public class ConsoleControllerTests
    {
        //private Mock<ISimulationService> _simulationServiceMock;
        //private Mock<CommandParser> _commandParserMock;
        //private Mock<IServiceProvider> _serviceProviderMock;
        //private Mock<IIOReadWriter> _ioReadWriterMock;
        //private ConsoleController _consoleController;

        //[SetUp]
        //public void Setup()
        //{
        //    _simulationServiceMock = new Mock<ISimulationService>();
        //    _commandParserMock = new Mock<CommandParser>();
        //    _serviceProviderMock = new Mock<IServiceProvider>();
        //    _ioReadWriterMock = new Mock<IIOReadWriter>();
        //    _consoleController = new ConsoleController(
        //        _simulationServiceMock.Object,
        //        _commandParserMock.Object,
        //        _serviceProviderMock.Object,
        //        _ioReadWriterMock.Object
        //    );
        //}

        //[Test]
        //public void Run_ValidFieldDimensionsInput_CreatesFieldAndShowsMainMenu()
        //{
        //    // Arrange
        //    _ioReadWriterMock.SetupSequence(m => m.StringReader())
        //        .Returns("10 10")
        //        .Returns("1")
        //        .Returns("A")
        //        .Returns("1 2 N")
        //        .Returns("FF")
        //        .Returns("2")
        //        .Returns("2");
        //    _simulationServiceMock.Setup(s=> s.Cars).Returns(new List<Car>());

        //    // Act
        //    _consoleController.Run();

        //    // Assert
        //    _simulationServiceMock.VerifySet(s => s.Field = It.IsAny<Field>(), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("You have created a field of 10 x 10."), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("Please choose from the following options:"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[1] Add a car to the field"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[2] Run simulation"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[3] Exit"), Times.Once);
        //}

        //[Test]
        //public void Run_InvalidFieldDimensionsInput_PromptsUserToTryAgain()
        //{
        //    // Arrange
        //    _ioReadWriterMock.SetupSequence(m => m.StringReader())
        //        .Returns("invalid")
        //        .Returns("10 10")
        //        .Returns("2");

        //    // Act
        //    _consoleController.Run();

        //    // Assert
        //    _simulationServiceMock.VerifySet(s => s.Field = It.IsAny<Field>(), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("Invalid field dimensions. Please try again."), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("You have created a field of 10 x 10."), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("Please choose from the following options:"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[1] Add a car to the field"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[2] Run simulation"), Times.Once);
        //    _ioReadWriterMock.Verify(m => m.StringWriter("[3] Exit"), Times.Once);
        //}        
    }    
}
