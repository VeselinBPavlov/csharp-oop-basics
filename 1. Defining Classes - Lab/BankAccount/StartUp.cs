namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var command = data[0];

                switch (command)
                {
                    case "Create": Create(data, accounts); break;
                    case "Deposit": Operation(data, accounts); break;
                    case "Withdraw": Operation(data, accounts); break;
                    case "Print": Print(data, accounts); break;
                    default: break;

                }

                input = Console.ReadLine();
            }
        }

        private static void Print(string[] data, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(data[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id]);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Operation(string[] data, Dictionary<int, BankAccount> accounts)
        {           
            var id = int.Parse(data[1]);
            var ammount = decimal.Parse(data[2]);

            if (accounts.ContainsKey(id))
            {
                if (data[0] == "Deposit")
                {
                    accounts[id].Deposit(ammount);
                }
                else
                {
                    var ballance = accounts[id].Balance;
                    if (ballance >= ammount)
                    {
                        accounts[id].Withdraw(ammount);
                    } 
                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                }                
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] data, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(data[1]);

            if (accounts.ContainsKey(id) == false)
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts[id] = acc;
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
