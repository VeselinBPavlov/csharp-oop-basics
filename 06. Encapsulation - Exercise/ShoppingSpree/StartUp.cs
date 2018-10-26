namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var shopping = new List<Person>();
            var products = new List<Product>();

            GetPeople(shopping);

            GetProducts(products);

            CreateShopping(shopping, products);
            
            PrintResult(shopping);
        }

        private static void PrintResult(List<Person> shopping)
        {
            shopping.ForEach(p => Console.WriteLine(p));
        }

        private static void CreateShopping(List<Person> shopping, List<Product> products)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var data = command.Split();
                var personName = data[0];
                var productName = data[1];

                shopping
                    .FirstOrDefault(x => x.Name == personName)
                    .BuyProduct(products.FirstOrDefault(p => p.Name == productName));
            }
        }

        private static void GetProducts(List<Product> products)
        {
            var productsData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsData.Length; i++)
            {
                var data = productsData[i].Split('=');
                var name = data[0];
                var cost = decimal.Parse(data[1]);

                try
                {
                    var product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }

        private static void GetPeople(List<Person> shopping)
        {
            var poplesData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var personData in poplesData)
            {
                var data = personData.Split('=');
                var name = data[0];
                var money = decimal.Parse(data[1]);

                try
                {
                    var person = new Person(name, money);
                    shopping.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
