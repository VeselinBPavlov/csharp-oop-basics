namespace MordorsCruelPlan.Factories
{
    using MordorsCruelPlan.Moods;
    using System;

    public class MoodFactory
    {
        public Mood CreateMood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "angry": return new Angry();
                case "happy": return new Happy();
                case "sad": return new Sad();
                case "javascript": return new JavaScript();
                default: throw new Exception("Invalid type!");
            }
        }
    }
}
