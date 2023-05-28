namespace CarSimulation.Model
{
    public class OperatingCar : CarBase
    {
        public string SimulatedCommands { get; set; }

        public bool IsCollision { get; set; } // Indicates if the car has collided with another car


        public OperatingCar(string name, Position position, Direction direction, string commands)
        {
            Name = name;
            SimulatedPosition = position;
            SimulatedDirection = direction;
            SimulatedCommands = commands;
            IsCollision = false;

        }

        public Position ExecuteNextCommand()
        {
            if (SimulatedCommands.Length > 0)
            {
                char nextCommand = SimulatedCommands[0];
                SimulatedCommands = SimulatedCommands.Substring(1);

                switch (nextCommand)
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'F':
                        return MoveForward();
                    default:
                        break;
                }
            }
            return SimulatedPosition;
        }

        private void RotateLeft()
        {
            SimulatedDirection = SimulatedDirection switch
            {
                Direction.N => Direction.W,
                Direction.W => Direction.S,
                Direction.S => Direction.E,
                Direction.E => Direction.N,
                _ => throw new InvalidOperationException("Invalid direction."),
            };
        }

        private void RotateRight()
        {
            SimulatedDirection = SimulatedDirection switch
            {
                Direction.N => Direction.E,
                Direction.E => Direction.S,
                Direction.S => Direction.W,
                Direction.W => Direction.N,
                _ => throw new InvalidOperationException("Invalid direction."),
            };
        }

        private Position MoveForward()
        {
            Position newPosition = SimulatedDirection switch
            {
                Direction.N => new Position(SimulatedPosition.X, SimulatedPosition.Y + 1),
                Direction.E => new Position(SimulatedPosition.X + 1, SimulatedPosition.Y),
                Direction.S => new Position(SimulatedPosition.X, SimulatedPosition.Y - 1),
                Direction.W => new Position(SimulatedPosition.X - 1, SimulatedPosition.Y),
                _ => throw new InvalidOperationException("Invalid direction."),
            };
            return newPosition;
        }
    }

}
