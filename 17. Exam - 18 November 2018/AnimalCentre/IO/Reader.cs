namespace AnimalCentre.IO
{
    using System;

    public class Reader : IReader
    {
        public string readData()
        {
            return Console.ReadLine();
        }
    }
}