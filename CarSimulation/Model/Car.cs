using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulation.Model
{
    public class Car
    {
        public string Name { get; private set; }
        //public Position OriginalPosition { get; set; }
        public Position SimulatedPosition { get; set; }
        //public Direction OriginalDirection { get; set; } 
        public Direction SimulatedDirection { get; set; }
        public string SimulatedCommands { get; set; }
        //public string OriginalCommands { get; set; }
        public bool IsCollision { get; set; } // Indicates if the car has collided with another car
                                              // public bool IsOutbound { get; set; } // indicate if the car had an instruction which pushed it to outbound

        public Car(string name, Position position, Direction direction, string commands)
        {
            Name = name;
            //OriginalDirection = direction;
            //OriginalPosition = position;
            SimulatedPosition = position;
            SimulatedDirection = direction;
            SimulatedCommands = commands;
            //OriginalCommands = commands;
            IsCollision = false; // Initialize collision status to false
            //IsOutbound = false;
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
