using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulation
{
    public interface IIOReadWriter
    {
       string StringReader();
       void StringWriter(string output);
    }
}
