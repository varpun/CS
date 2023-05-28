using CarSimulation.Model;

namespace CarSimulation
{
    public class SimulationService : ISimulationService, IDisposable
    {
        public List<Car> Cars { get; private set; }
        public Field Field { get; set; }
        public Dictionary<int, List<Car>> CarCollisionList { get; private set; }
        public SimulationService(Field field, List<Car> cars, Dictionary<int, List<Car>> carCollisionList)
        {
            Cars = cars;
            Field = field;
            CarCollisionList = carCollisionList;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RunSimulation()
        {
            int totalSteps = GetTotalSteps();
            InitializeCarListValidity();
            for (int step = 1; step <= totalSteps; step++)
            {
                foreach (Car car in Cars.Where(p => !p.IsCollision))
                {
                    var newPosition = car.ExecuteNextCommand();
                    if (!newPosition.Equals(car.SimulatedPosition) && !IsCollisionOutOfBound(step, car, newPosition))
                    {
                        car.SimulatedPosition = newPosition;
                    }
                }
            }
        }

        private bool IsCollisionOutOfBound(int step, Car car, Position newPosition)
        {
            if (IsCollision(car, step, newPosition) || !IsWithinBounds(newPosition))
            {
                return true;
            }
            return false;
        }

        private void InitializeCarListValidity()
        {
            foreach (Car car in Cars)
            {
                IsCollisionOutOfBound(0, car, car.SimulatedPosition);
            }
        }

        private int GetTotalSteps()
        {
            int maxCommands = Cars.Max(car => car.SimulatedCommands.Length);
            return maxCommands;
        }

        private bool IsCollision(Car currentCar, int step, Position newPosition)
        {
            var carList = new List<Car>();
            if (CarCollisionList.ContainsKey(step))
            {
                carList = CarCollisionList[step];
            }
            var stepCollisionStatus = false;
            foreach (Car car in Cars)
            {
                if (!car.Name.Equals(currentCar.Name, StringComparison.OrdinalIgnoreCase) && car.SimulatedPosition.Equals(newPosition))
                {
                    car.IsCollision = true;
                    currentCar.IsCollision = true;
                    currentCar.SimulatedPosition = newPosition;
                    stepCollisionStatus = true;
                    if (!carList.Contains(car))
                    {
                        carList.Add(car);
                    }
                    if (!carList.Contains(currentCar))
                    {
                        carList.Add(currentCar);
                    }
                }
            }
            if (CarCollisionList.ContainsKey(step))
            {
                CarCollisionList[step] = carList;
            }
            else
            {
                CarCollisionList.Add(step, carList);
            }
            return stepCollisionStatus;
        }

        public bool IsWithinBounds(Position position)
        {
            // Check if the given position is within the field boundaries
            return position.X >= 0 && position.X < Field.Width &&
                   position.Y >= 0 && position.Y < Field.Height;
        }

        public void Dispose()
        {
            Cars.Clear();
            CarCollisionList.Clear();
        }
    }
}
