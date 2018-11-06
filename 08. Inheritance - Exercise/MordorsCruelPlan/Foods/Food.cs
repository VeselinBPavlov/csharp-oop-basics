namespace MordorsCruelPlan.Foods
{
    using System;

    public abstract class Food
    { 
        public int Happiness { get; }

        public Food(int happiness)
        {
            this.Happiness = happiness;
        }
    }
}
