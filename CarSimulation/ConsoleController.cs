using CarSimulation.Model;
using Microsoft.Extensions.DependencyInjection;

namespace CarSimulation
{
    public class ConsoleController
    {
        private ISimulationService _simulation;
        private CommandParser _commandParser;
        private IServiceProvider _serviceProvider;
        private IIOReadWriter _ioReadWriter;

        public ConsoleController(ISimulationService simulationService, CommandParser commandParser, IServiceProvider serviceProvider, IIOReadWriter ioReadWriter)
        {
            _simulation = simulationService;
            _commandParser = commandParser;
            _serviceProvider = serviceProvider;
            _ioReadWriter = ioReadWriter;
        }

        public void Run()
        {
            _ioReadWriter.StringWriter("Welcome to Auto Driving Car Simulation!");

            while (true)
            {
                _ioReadWriter.StringWriter("Please enter the width and height of the simulation field in x y format:");
                string fieldDimensionsInput = _ioReadWriter.StringReader();

                if (_commandParser.TryParseFieldDimensions(fieldDimensionsInput, out int width, out int height))
                {
                    _simulation.Field = new Field(width, height);
                    _ioReadWriter.StringWriter($"You have created a field of {width} x {height}.");

                    ShowMainMenu();
                    break;
                }
                else
                {
                    _ioReadWriter.StringWriter("Invalid field dimensions. Please try again.");
                }
            }
        }

        private void ShowMainMenu()
        {
            while (true)
            {
                _ioReadWriter.StringWriter("Please choose from the following options:");
                _ioReadWriter.StringWriter("[1] Add a car to the field");
                _ioReadWriter.StringWriter("[2] Run simulation");
                _ioReadWriter.StringWriter("[3] Exit");

                string userInput = _ioReadWriter.StringReader();

                switch (userInput)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        RunSimulation();
                        break;
                    case "3":
                        ExitProgram();
                        return;
                    default:
                        _ioReadWriter.StringWriter("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ShowPostSimulationMenu()
        {
            while (true)
            {
                _ioReadWriter.StringWriter("Please choose from the following options:");
                _ioReadWriter.StringWriter("[1] Start Over");
                _ioReadWriter.StringWriter("[2] Exit");

                string userInput = _ioReadWriter.StringReader();

                switch (userInput)
                {
                    case "1":
                        _simulation.Dispose();
                        _simulation = _serviceProvider.GetService<ISimulationService>();
                        Run();
                        break;
                    case "2":
                        ExitProgram();
                        break;
                    default:
                        _ioReadWriter.StringWriter("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void AddCar()
        {
            _ioReadWriter.StringWriter("Please enter the name of the car:");
            string carName = _ioReadWriter.StringReader();

            _ioReadWriter.StringWriter("Please enter the initial position of the car in x y Direction format:");
            string carDetailsInput = _ioReadWriter.StringReader();

            if (_commandParser.TryParseCarDetails(carDetailsInput, out Position position, out Direction direction))
            {
                if (!_simulation.IsWithinBounds(position))
                {
                    _ioReadWriter.StringWriter("Please enter an initial position which is within the field boundary");
                }
                else
                {
                    _ioReadWriter.StringWriter("Please enter the commands for the car:");
                    string commandsInput = _ioReadWriter.StringReader();

                    if (_commandParser.ValidateCommands(commandsInput))
                    {
                        Car car = new Car(carName, position, direction, commandsInput);
                        _simulation.AddCar(car);

                        _ioReadWriter.StringWriter($"Car {car.Name} added successfully at ({car.SimulatedPosition.X},{car.SimulatedPosition.Y})");

                    }
                    else
                    {
                        _ioReadWriter.StringWriter("Invalid commands. Please try again.");
                    }
                }
            }
            else
            {
                _ioReadWriter.StringWriter("Invalid car details. Please try again.");
            }
        }

        private void RunSimulation()
        {
            if (_simulation.Cars.Count == 0)
            {
                _ioReadWriter.StringWriter("No cars added to the field. Please add cars before running the simulation.");
                return;
            }

            _ioReadWriter.StringWriter("Running simulation...");

            _simulation.RunSimulation();
            PrintSimulationState();

            _ioReadWriter.StringWriter("Simulation completed.");

            ShowPostSimulationMenu();
        }

        private void PrintSimulationState()
        {
            _ioReadWriter.StringWriter("After simulation your status of current list of cars are:");
            if (_simulation.CarCollisionList != null && _simulation.CarCollisionList.Any())
            {
                //Iterate through different steps to get the list of cars involved in collision at each step
                foreach (var step in _simulation.CarCollisionList.Keys)
                {
                    foreach (var car in _simulation.CarCollisionList[step])
                    {
                        foreach (var otherCars in _simulation.CarCollisionList[step].Where(p => !p.Name.Equals(car.Name)))
                        {
                            _ioReadWriter.StringWriter($"{car.Name} collides with {otherCars.Name} at ({car.SimulatedPosition.X},{car.SimulatedPosition.Y}) at step {step}");
                        }
                    }
                }
            }

            foreach (Car car in _simulation.Cars.Where(p => !p.IsCollision))
            {
                _ioReadWriter.StringWriter($"{car.Name}, {car.SimulatedPosition.X} {car.SimulatedPosition.Y} {car.SimulatedDirection}");
            }

        }

        private void ExitProgram()
        {
            _ioReadWriter.StringWriter("Thank you for running the simulation. Goodbye!");
            Environment.Exit(0);
        }
    }
}
