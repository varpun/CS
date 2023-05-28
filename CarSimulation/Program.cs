// See https://aka.ms/new-console-template for more information
using CarSimulation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IIOReadWriter,ConsoleReadWriter>();
        services.AddScoped<Car>();
        services.AddScoped<Position>();
        services.AddScoped<Field>();
        services.AddTransient(_ =>new List<Car>());
        services.AddTransient(_ => new Dictionary<int,List<Car>>());
        services.AddScoped<ISimulationService,SimulationService>();
        services.AddScoped<CommandParser>();
        services.AddScoped<ConsoleController>();
    })
    .Build();
        //Console.WriteLine("Welcome to Auto Driving Car Simulation!");

        //Console.WriteLine("Please enter the width and height of the simulation field in x y format:");
        //string[] fieldDimensions = Console.ReadLine()?.Split(' ');
        //int width = int.Parse(fieldDimensions[0]);
        //int height = int.Parse(fieldDimensions[1]);
        //Field field = new Field(width, height);

        //Simulation simulation = new Simulation(field);

        //bool running = true;
        //while (running)
        //{
        //    Console.WriteLine("\nPlease choose from the following options:");
        //    Console.WriteLine("[1] Add a car to the field");
        //    Console.WriteLine("[2] Run simulation");
        //    Console.WriteLine("[3] Exit");

        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            AddCarToField(simulation);
        //            break;
        //        case "2":
        //            RunSimulation(simulation);
        //            break;
        //        case "3":
        //            running = false;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}

        //Console.WriteLine("Thank you for running the simulation. Goodbye!");
        var runner = host.Services.GetService<ConsoleController>();
        runner.Run();
        await host.RunAsync();
    }

    //static void AddCarToField(SimulationService simulation)
    //{
    //    Console.WriteLine("Please enter the name of the car:");
    //    string name = Console.ReadLine();

    //    Console.WriteLine("Please enter the initial position of the car in x y Direction format:");
    //    string[] positionInfo = Console.ReadLine()?.Split(' ');
    //    int x = int.Parse(positionInfo[0]);
    //    int y = int.Parse(positionInfo[1]);
    //    Direction direction = (Direction)Enum.Parse(typeof(Direction), positionInfo[2]);

    //    Console.WriteLine("Please enter the commands for the car:");
    //    string commands = Console.ReadLine();

    //    //simulation.AddCar(car);

    //    Console.WriteLine("Car added successfully!");
    //}

    //static void RunSimulation(SimulationService simulation)
    //{
    //    simulation.RunSimulation();

    //    Console.WriteLine("Simulation completed.");
    //    Console.WriteLine("Your current list of cars are:");
    //    //simulation.PrintFinalPositions();
    //}
}
