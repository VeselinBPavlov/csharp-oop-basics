﻿namespace FoodShortage.Contracts
{
    public interface IBuyer
    {
        int Food { get; }

        void BuyFood();
    }
}
