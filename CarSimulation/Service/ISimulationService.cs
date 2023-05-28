using CarSimulation.Model;

namespace CarSimulation.Service
{
    public interface ISimulationService
    {
        Dictionary<int, List<OperatingCar>> CarCollisionList { get; }
        List<OperatingCar> Cars { get; }
        Field Field { get; set; }

        void AddCar(OperatingCar car);
        bool IsWithinBounds(Position position);
        void RunSimulation();
        void Dispose();
    }
}