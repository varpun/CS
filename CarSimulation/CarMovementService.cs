using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSimulation.Model;

namespace CarSimulation
{
    public class CarMovement
    {
        private readonly Field field;

        public CarMovement(Field field)
        {
            this.field = field;
        }

        // Move the car forward by one grid point in the current direction
        //public bool MoveForward(Car car)
        //{
        //    Position newPosition = car.Position.GetNextPosition(car.FacingDirection);
        //    if (field.IsValidPosition(newPosition))
        //    {
        //        car.Position = newPosition;
        //        return true;
        //    }

        //    return false;
        //}

        // Rotate the car 90 degrees to the left
        //public void RotateLeft(Car car)
        //{
        //    car.FacingDirection = car.FacingDirection.GetLeftDirection();
        //}

        //// Rotate the car 90 degrees to the right
        //public void RotateRight(Car car)
        //{
        //    car.FacingDirection = car.FacingDirection.GetRightDirection();
        //}
    }
}
