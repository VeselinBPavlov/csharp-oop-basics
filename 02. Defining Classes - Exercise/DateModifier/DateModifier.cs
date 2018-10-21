namespace DateModifier
{
    using System;

    public class DateModifier
    {
        // Method.
        public int GetDifference(string firstDate, string secondDate)
        {
            var dateOne = DateTime.Parse(firstDate);
            var dateTwo = DateTime.Parse(secondDate);

            var difference = Math.Abs((dateOne - dateTwo).Days);

            return difference;
        }
    }
}
