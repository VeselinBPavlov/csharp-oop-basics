namespace AnimalCentre
{
    using AnimalCentre.Core;
    using AnimalCentre.IO;

    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();

            var engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
