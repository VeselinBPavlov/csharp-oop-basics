namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        // Field.
        private Random random = new Random();

        // Method.
        public string RandomString()
        {
            var element = "";
            if (this.Count > 0)
            {
                var index = random.Next(0, this.Count - 1);
                element = this[index];
                this.RemoveAt(index);
            }
            return element;
        }
    }
}
