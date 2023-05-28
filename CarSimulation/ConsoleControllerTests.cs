//using Moq;
//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarSimulation
{
    //[TestFixture]
    //public class ConsoleControllerTests
    //{
        //[Fact]
        //public void Run_ValidFieldDimensions_Success()
        //{
        //    // Arrange
        //    var simulationServiceMock = new Mock<ISimulationService>();
        //    var commandParserMock = new Mock<CommandParser>();
        //    var serviceProviderMock = new Mock<IServiceProvider>();
        //    var ioReadWriterMock = new Mock<IIOReadWriter>();

        //    var controller = new ConsoleController(
        //        simulationServiceMock.Object,
        //        commandParserMock.Object,
        //        serviceProviderMock.Object,
        //        ioReadWriterMock.Object
        //    );

        //    ioReadWriterMock.SetupSequence(rw => rw.StringReader())
        //        .Returns("5 5")
        //        .Returns("2");

        //    // Act
        //    controller.Run();

        //    // Assert
        //    ioReadWriterMock.Verify(rw => rw.StringWriter("You have created a field of 5 x 5."), Times.Once);
        //}

        //[Fact]
        //public void Run_InvalidFieldDimensions_Retry()
        //{
        //    // Arrange
        //    var simulationServiceMock = new Mock<ISimulationService>();
        //    var commandParserMock = new Mock<CommandParser>();
        //    var serviceProviderMock = new Mock<IServiceProvider>();
        //    var ioReadWriterMock = new Mock<IIOReadWriter>();

        //    var controller = new ConsoleController(
        //        simulationServiceMock.Object,
        //        commandParserMock.Object,
        //        serviceProviderMock.Object,
        //        ioReadWriterMock.Object
        //    );

        //    ioReadWriterMock.SetupSequence(rw => rw.StringReader())
        //        .Returns("invalid")
        //        .Returns("5 5")
        //        .Returns("2");

        //    // Act
        //    controller.Run();

        //    // Assert
        //    ioReadWriterMock.Verify(rw => rw.StringWriter("Invalid field dimensions. Please try again."), Times.Once);
        //    ioReadWriterMock.Verify(rw => rw.StringWriter("You have created a field of 5 x 5."), Times.Once);
        //}

        //[Fact]
        //public void ShowMainMenu_ValidChoice_AddCar()
        //{
        //    // Arrange
        //    var simulationServiceMock = new Mock<ISimulationService>();
        //    var commandParserMock = new Mock<CommandParser>();
        //    var serviceProviderMock = new Mock<IServiceProvider>();
        //    var ioReadWriterMock = new Mock<IIOReadWriter>();

        //    var controller = new ConsoleController(
        //        simulationServiceMock.Object,
        //        commandParserMock.Object,
        //        serviceProviderMock.Object,
        //        ioReadWriterMock.Object
        //    );

        //    ioReadWriterMock.SetupSequence(rw => rw.StringReader())
        //        .Returns("1");

        //    // Act
        //    controller.ShowMainMenu();

        //    // Assert
        //    ioReadWriterMock.Verify(rw => rw.StringWriter("[1] Add a car to the field"), Times.Once);
        //    ioReadWriterMock.Verify(rw => rw.StringWriter("Invalid choice. Please try again."), Times.Never);
        //    // Add assertions for the behavior of the AddCar() method
        //}
        //[Test]
        //public void ConsoleUI_DisplayWelcomeMessage_PrintsWelcomeMessage()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayWelcomeMessage();

        //    // Assert
        //    string expectedMessage = "Welcome to Auto Driving Car Simulation!";
        //    Assert.AreEqual(expectedMessage, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayPromptForFieldDimensions_PrintsPrompt()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayPromptForFieldDimensions();

        //    // Assert
        //    string expectedPrompt = "Please enter the width and height of the simulation field in x y format:";
        //    Assert.AreEqual(expectedPrompt, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayPromptForCarName_PrintsPrompt()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayPromptForCarName();

        //    // Assert
        //    string expectedPrompt = "Please enter the name of the car:";
        //    Assert.AreEqual(expectedPrompt, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayPromptForCarPosition_PrintsPrompt()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayPromptForCarPosition();

        //    // Assert
        //    string expectedPrompt = "Please enter initial position of the car in x y Direction format:";
        //    Assert.AreEqual(expectedPrompt, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayPromptForCarCommands_PrintsPrompt()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayPromptForCarCommands();

        //    // Assert
        //    string expectedPrompt = "Please enter the commands for the car:";
        //    Assert.AreEqual(expectedPrompt, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayCarList_PrintsCarList()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();
        //    string[] carList = new string[] { "A, (1,2) N, FFRFF", "B, (3,4) S, LLFF" };

        //    // Act
        //    //consoleUI.DisplayCarList(carList);

        //    // Assert
        //    string expectedOutput = "Your current list of cars are:\nA, (1,2) N, FFRFF\nB, (3,4) S, LLFF";
        //    Assert.AreEqual(expectedOutput, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayPromptForUserChoice_PrintsPrompt()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayPromptForUserChoice();

        //    // Assert
        //    string expectedPrompt = "Please choose from the following options" +
        //    "\n[1] Add a car to the field\n[2] Run simulation";
        //    Assert.AreEqual(expectedPrompt, stringWriter.ToString().Trim());
        //}


        //[Test]
        //public void ConsoleUI_DisplaySimulationResult_PrintsSimulationResult()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();
        //    string[] simulationResult = new string[] { "A, collides with B at (2,3) at step 5", "B, (4,5) N" };

        //    // Act
        //    //consoleUI.DisplaySimulationResult(simulationResult);

        //    // Assert
        //    string expectedOutput = "After simulation, the result is:\nA, collides with B at (2,3) at step 5\nB, (4,5) N";
        //    Assert.AreEqual(expectedOutput, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void ConsoleUI_DisplayExitMessage_PrintsExitMessage()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);
        //    ConsoleUI consoleUI = new ConsoleUI();

        //    // Act
        //    //consoleUI.DisplayExitMessage();

        //    // Assert
        //    string expectedMessage = "Thank you for running the simulation. Goodbye!";
        //    Assert.AreEqual(expectedMessage, stringWriter.ToString().Trim());
        //}

    //}
}
