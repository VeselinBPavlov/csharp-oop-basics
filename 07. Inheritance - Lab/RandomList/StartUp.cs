namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var randomList = new RandomList() { "Pesho", "Gosho", "Sasho", "Tosho", "Misho", "Tisho", "Grisho" };
            
            while (randomList.Count > 0)
            {
                Console.WriteLine(randomList.RandomString());
            }
        }
    }
}
