namespace CarSimulation
{
    public class ConsoleReadWriter : IIOReadWriter
    {
        public string StringReader()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public void StringWriter(string output)
        {
            Console.WriteLine(output);
        }
    }
}