namespace CarSimulation
{
    public interface ISimulationService
    {
        Dictionary<int, List<Car>> CarCollisionList { get; }
        List<Car> Cars { get; }
        Field Field { get; set; }

        void AddCar(Car car);
        bool IsWithinBounds(Position position);
        void RunSimulation();
        void Dispose();
    }
}