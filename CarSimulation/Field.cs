using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulation
{
    public class Field
    {
        public int Width { get;  set; }
        public int Height { get;  set; }

        public Field(int width =0, int height = 0)
        {
            Width = width;
            Height = height;
        }
        
    }

}
