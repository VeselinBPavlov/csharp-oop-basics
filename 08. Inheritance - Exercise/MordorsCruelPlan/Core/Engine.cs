namespace MordorsCruelPlan.Core
{
    using MordorsCruelPlan.Factories;
    using MordorsCruelPlan.Moods;
    using System;

    public class Engine
    {
        private FoodFactory foodFactory;
        private MoodFactory moodFactory;

        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();
        }

        public void Run()
        {
            var points = 0;
            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                var type = input[i];

                var currentFood = foodFactory.CreateFood(type);
                points += currentFood.Happiness;
            }

            Mood mood;
            if (points < -5)
            {
                mood = moodFactory.CreateMood("angry");
            }
            else if (points >= -5 && points < 0)
            {
                mood = moodFactory.CreateMood("sad");
            }
            else if (points >= 1 && points < 15)
            {
                mood = moodFactory.CreateMood("happy");
            }
            else
            {
                mood = moodFactory.CreateMood("javascript");
            }

            Console.WriteLine(points);
            Console.WriteLine(mood.Name);
        }
    }
}
