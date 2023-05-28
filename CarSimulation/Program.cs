// See https://aka.ms/new-console-template for more information
using CarSimulation;
using CarSimulation.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static async Task Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddScoped<IIOReadWriter, ConsoleReadWriter>();
            services.AddScoped<Car>();
            services.AddScoped<Position>();
            services.AddScoped<Field>();
            services.AddTransient(_ => new List<Car>());
            services.AddTransient(_ => new Dictionary<int, List<Car>>());
            services.AddScoped<ISimulationService, SimulationService>();
            services.AddScoped<CommandParser>();
            services.AddScoped<ConsoleController>();
        })
        .Build();
        var runner = host.Services.GetService<ConsoleController>();
        runner.Run();
        await host.RunAsync();
    }
}
