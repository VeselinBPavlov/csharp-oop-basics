﻿namespace AnimalCentre.IO
{
    public interface IWriter
    {
        void WriteLine(string message);
        void Flush();
    }
}
