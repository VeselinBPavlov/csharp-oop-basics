﻿namespace VehiclesExtension
{
    using VehiclesExtension.Core;

    public class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
