//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulation
{
    //[TestFixture]
    //public class IntegrationTests
    //{
        //[Test]
        //public void RunSimulation_SingleCarSimulation_Success()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);

        //    StringReader stringReader = new StringReader("10 10\n1\nA\n1 2 N\nFFRFF\n2\n2\n");
        //    Console.SetIn(stringReader);

        //    SimulationService simulation = new SimulationService(new Field(10,10));

        //    // Act
        //    simulation.RunSimulation();

        //    // Assert
        //    string expectedOutput = "Welcome to Auto Driving Car Simulation!\n" +
        //                            "Please enter the width and height of the simulation field in x y format:\n" +
        //                            "You have created a field of 10 x 10.\n" +
        //                            "Please choose from the following options:\n" +
        //                            "[1] Add a car to field\n" +
        //                            "[2] Run simulation\n" +
        //                            "Please enter the name of the car:\n" +
        //                            "Please enter initial position of car A in x y Direction format:\n" +
        //                            "Please enter the commands for car A:\n" +
        //                            "Your current list of cars are:\n" +
        //                            "A, (1,2) N, FFRFF\n" +
        //                            "Please choose from the following options:\n" +
        //                            "[1] Add a car to field\n" +
        //                            "[2] Run simulation\n" +
        //                            "Your current list of cars are:\n" +
        //                            "A, (4,3) E\n" +
        //                            "Please choose from the following options:\n" +
        //                            "[1] Start over\n" +
        //                            "[2] Exit\n" +
        //                            "Thank you for running the simulation. Goodbye!";

        //    Assert.AreEqual(expectedOutput, stringWriter.ToString().Trim());
        //}

        //[Test]
        //public void RunSimulation_MultipleCarSimulation_Success()
        //{
        //    // Arrange
        //    StringWriter stringWriter = new StringWriter();
        //    Console.SetOut(stringWriter);

        //    StringReader stringReader = new StringReader("10 10\n1\nA\n1 2 N\nFFRFF\n1\nB\n3 4 S\nLLFF\n2\n2\n");
        //    Console.SetIn(stringReader);

        //    SimulationService simulation = new SimulationService(new Field(10, 10));

        //    // Act
        //    simulation.RunSimulation();

        //    // Assert
        //    string expectedOutput = "Welcome to Auto Driving Car Simulation!\n" +
        //                            "Please enter the width and height of the simulation field in x y format:\n" +
        //                            "You have created a field of 10 x 10.\n" +
        //                            "Please choose from the following options:\n" +
        //                            "[1] Add a car to field\n" +
        //                            "[2] Run simulation\n" +
        //                            "Please enter the name of the car:\n" +
        //                            "Please enter initial position of car A in x y Direction format:\n" +
        //                            "Please enter the commands for car A:\n" +
        //                            "Your current list of cars are:\n" +
        //                            "A, (1,2) N, FFRFF\n" +
        //                            "Please choose from the following options:\n" +
        //                            "[1] Add a car to field\n" +
        //                            "[2] Run simulation\n" +
        //                            "Please enter the name of the car:\n" +
        //                            "Please enter initial position of car B in x y Direction format:\n" +
        //                            "Please enter the commands for car B:\n" +
        //                            "Your current list of cars are:\n" +
        //                             "A, (1,2) N, FFRFF\n" +
        //                               "B, (3,4) S, LLFF\n" +
        //                        "Please choose from the following options:\n" +
        //                        "[1] Add a car to field\n" +
        //                        "[2] Run simulation\n" +
        //                        "Your current list of cars are:\n" +
        //                        "A, (4,3) E\n" +
        //                        "B, (2,3) S\n" +
        //                        "Please choose from the following options:\n" +
        //                        "[1] Start over\n" +
        //                        "[2] Exit\n" +
        //                        "Thank you for running the simulation. Goodbye!";

        //    Assert.AreEqual(expectedOutput, stringWriter.ToString().Trim());
        //}
        //}
    }
