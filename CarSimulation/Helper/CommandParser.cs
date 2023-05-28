using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSimulation.Model;

namespace CarSimulation.Helper
{
    public class CommandParser
    {
        public bool TryParseFieldDimensions(string input, out int width, out int height)
        {
            width = 0;
            height = 0;

            string[] dimensions = input.Split(' ');

            if (dimensions.Length == 2 && int.TryParse(dimensions[0], out width) && int.TryParse(dimensions[1], out height))
            {
                // Validate the field dimensions
                if (width > 0 && height > 0)
                {
                    return true; // Successfully parsed the field dimensions
                }
            }

            return false; // Invalid field dimensions
        }

        public bool TryParseCarDetails(string input, out Position position, out Direction direction)
        {
            position = null;
            direction = Direction.N;

            string[] details = input.Split(' ');

            if (details.Length == 3)
            {

                if (int.TryParse(details[0], out int x) && int.TryParse(details[1], out int y))
                {
                    position = new Position(x, y);

                    // Validate the car direction
                    if (Enum.TryParse(details[2], out direction))
                    {
                        return true; // Successfully parsed the car details
                    }
                }
            }

            return false; // Invalid car details
        }

        public bool ValidateCommands(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            // Validate the commands by checking if each character is a valid command (L, R, or F)
            foreach (char command in input)
            {
                if (command != 'L' && command != 'R' && command != 'F')
                {
                    return false; // Invalid command detected
                }
            }

            return true; // All commands are valid
        }
    }
}
